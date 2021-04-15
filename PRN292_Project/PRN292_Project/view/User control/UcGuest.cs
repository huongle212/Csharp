using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class UcGuest : UserControl
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;

        public UcGuest()
        {
            InitializeComponent();
            cbFilterGender.SelectedIndex = 2;
            btnNext.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatAppearance.BorderSize = 0;
        }

        private void UcGuest_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Guest", FrmHome.Strconn);
            dataSet = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataSet, "Guest");
            this.guestTableAdapter.Fill(this.pRN292_HotelDBDataSet.Guest);
            AllGuest(this.dgvGuest);
            btnCancel_Click(null, null);
        }

        private void dgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGuest.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvGuest.Rows[selectedRowIndex];
            if (selectedRowIndex > -1 && selectedRowIndex < dgvGuest.Rows.Count)
            {
                if (selectedRowIndex >= dgvGuest.Rows.Count - 1)
                {
                    setDislayButton(false);
                }
                else
                {
                    cbGender.Checked = (row.Cells[5].Value.ToString().Equals("True"));
                    cbxGuestId.SelectedValue = row.Cells[0].Value.ToString();
                    btnDelete.Enabled = !checkGuestStaying(cbxGuestId.SelectedValue.ToString());
                    setDislayButton(true);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFullname.Text.Length == 0) throw new Exception("Guest name can not be empty!");
                string idenNo = cbxIdentityNo.Text;
                string valid = validIdentityNo(idenNo);
                if (!valid.Equals("Valid")) throw new Exception(valid);
                valid = validPhone(txtPhone.Text);
                if (!valid.Equals("Valid")) throw new Exception(valid);
                if (checkIdentityNoExist(idenNo)) throw new Exception($"Identity number {idenNo} is in used!");
                int gId = createNewGuest();
                if (gId > 0)
                {
                    UcGuest_Load(null,null);
                    MessageBox.Show("Add new guest successfully!");
                }
                else MessageBox.Show("Add new guest fail!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gId = cbxGuestId.Text;
            try
            {
                if(gId.Length==0) throw new Exception("Guest id is required!");
                if (!checkGuestExist(gId)) throw new Exception($"GuestID {gId} doesn't exist!");
                if (cbxFullname.Text.Length == 0) throw new Exception("Guest name can not be empty!");
                String valid = validIdentityNo(cbxIdentityNo.Text);
                if (!valid.Equals("Valid")) throw new Exception(valid);
                if (!checkIdentityNoExist(gId, cbxIdentityNo.Text)) throw new Exception($"Identity number {cbxIdentityNo.Text} is in used!");
                valid = validPhone(txtPhone.Text);
                if (!valid.Equals("Valid")) throw new Exception(valid);
                DialogResult confirmed = MessageBox.Show($"Do you want to update guest {gId}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmed == DialogResult.Yes)
                {
                    DataRow dr = dataSet.Tables[0].Select($"guestId={gId}")[0];
                    dr.BeginEdit();
                    dr["fullname"] = cbxFullname.Text;
                    dr["identityNumber"] = cbxIdentityNo.Text;
                    dr["phone"] = txtPhone.Text;
                    dr["address"] = txtAddress.Text;
                    dr["gender"] = cbGender.Checked;
                    dr.EndEdit();
                    int kq = adapter.Update(dataSet, "Guest");
                    if (kq > 0)
                    {
                        UcGuest_Load(null, null);
                        MessageBox.Show("Update successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvGuest.ClearSelection();
            dgvGuest.Rows[dgvGuest.Rows.Count - 1].Cells[0].Selected = true;
            dgvGuest_CellClick(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string gId = cbxGuestId.SelectedValue.ToString();
            if (gId.Length > 0)
            {
                try
                {
                    if (!checkGuestExist(gId)) throw new Exception($"GuestID {gId} doesn't exist!");
                    DialogResult confirmed = MessageBox.Show($"Do you want to remove guest {gId}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmed == DialogResult.Yes)
                    {

                        DataRow dr = dataSet.Tables[0].Select($"guestId={gId}")[0];
                        dr.Delete();
                        adapter.Update(dataSet, dataSet.Tables[0].TableName);
                        AllGuest(dgvGuest);
                        btnCancel_Click(null,null);
                        MessageBox.Show("Delete successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Delete fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int curRowIndex = dgvGuest.SelectedCells[0].RowIndex;
            if (curRowIndex > 0)
            {
                curRowIndex--;
                dgvGuest.ClearSelection();
                dgvGuest.Rows[curRowIndex].Selected = true;
                dgvGuest_CellClick(null, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int curRowIndex = dgvGuest.SelectedCells[0].RowIndex;
            if (curRowIndex > -1 && curRowIndex < dgvGuest.Rows.Count - 2)
            {
                curRowIndex++;
                dgvGuest.ClearSelection();
                dgvGuest.Rows[curRowIndex].Selected = true;
                dgvGuest_CellClick(null, null);
            }
        }

        private void cbxGuestId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string id = cbxGuestId.Text;
                DataRow[] rows = dataSet.Tables[0].Select($"guestId={id}");
                if (rows.Length == 0) return;
                DataRow dr = rows[0];
                cbxGuestId.SelectedValue = dr["guestId"].ToString();
                cbxFullname.SelectedValue = dr["fullname"].ToString();
                cbxIdentityNo.SelectedValue = dr["identityNumber"].ToString();
                txtPhone.Text = dr["phone"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            catch (Exception ex) { }
        }

        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            int gender = cbFilterGender.SelectedIndex;
            string keyword = txtSearchGuest.Text;
            searchGuest(dgvGuest, keyword, gender);
        }

        private void cbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchGuest_TextChanged(null, null);
        }

        private void cbxGuestId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cbxIdentityNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cbxFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void AllGuest(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = dataSet.Tables[0];
                setGuestTableHeader(dataGridView);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchGuest(DataGridView dataGridView, string keyword, int gender)
        {
            try
            {
                string sql = $"select * from Guest where (guestId like N'%{keyword}%' or fullname like N'%{keyword}%'" +
                    $" or identityNumber like N'%{keyword}%' or phone like N'%{keyword}%' or address like N'%{keyword}%')";
                if (gender == 0 || gender == 1)
                    sql += $" and gender = {gender}";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
                setGuestTableHeader(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkGuestExist(String guestId)
        {
            try
            {
                return dataSet.Tables["Guest"].Select($"guestId={guestId}").Length > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool checkIdentityNoExist(String identityNo)
        {
            try
            {
                return dataSet.Tables["Guest"].Select($"identityNumber='{identityNo}'").Length > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool checkIdentityNoExist(String guestId, String identityNo)
        {
            try
            {
                DataRow row = dataSet.Tables["Guest"].Select($"identityNumber='{identityNo}'")[0];
                return row[0].ToString().Equals(guestId.ToString());
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool checkGuestStaying(string guestId)
        {
            try
            {
                string sql = $"select * from Checkin where checkoutTime is null and guestId={guestId}";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet.Tables[0].Rows.Count > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private int createNewGuest()
        {
            int id = -1;
            try
            {
                SqlConnection conn = null;
                if (conn == null) conn = new SqlConnection(FrmHome.Strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand("InsertGuest", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@fullname", cbxFullname.Text));
                command.Parameters.Add(new SqlParameter("@identityNo",cbxIdentityNo.Text));
                command.Parameters.Add(new SqlParameter("@phone",txtPhone.Text));
                command.Parameters.Add(new SqlParameter("@address",txtAddress.Text));
                command.Parameters.Add(new SqlParameter("@gender",cbGender.Checked));
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Direction = ParameterDirection.Output;
                int rc = command.ExecuteNonQuery();
                id = Convert.ToInt32(command.Parameters["@id"].Value);
                conn.Close();
                return id;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static void setGuestTableHeader(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "GuestID";
            dataGridView.Columns[1].HeaderText = "Fullname";
            dataGridView.Columns[2].HeaderText = "Identity No.";
            dataGridView.Columns[3].HeaderText = "Phone";
            dataGridView.Columns[4].HeaderText = "Address";
            dataGridView.Columns[5].HeaderText = "Gender";
            dataGridView.Columns[0].Width = 60;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 120;
            dataGridView.Columns[5].MinimumWidth = 70;
        }

        private void setDislayButton(bool update)
        {
            int curRowIndex = dgvGuest.SelectedCells[0].RowIndex;
            btnAdd.Visible = !update;
            btnUpdate.Visible = update;
            btnCancel.Visible = update;
            btnDelete.Visible = update;           
            btnPrevious.Visible = update;
            btnNext.Visible = update;
            cbxGuestId.Enabled = update;
            cbxFullname.DropDownStyle = update?ComboBoxStyle.DropDown:ComboBoxStyle.Simple;
            cbxIdentityNo.DropDownStyle = update ? ComboBoxStyle.DropDown : ComboBoxStyle.Simple;
            btnPrevious.Enabled = curRowIndex > 0;
            btnNext.Enabled = curRowIndex < dgvGuest.Rows.Count - 2;
            if (!update)
            {
                dgvGuest.ClearSelection();
                dgvGuest.Rows[dgvGuest.Rows.Count - 1].Selected = true;
                cbxGuestId.SelectedIndex = -1;
                cbxFullname.SelectedIndex = -1;
                cbxIdentityNo.SelectedIndex = -1;
                cbGender.Checked = false;
                txtAddress.Text = "";
                txtPhone.Text = "";               
            }
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            String phone = txtPhone.Text;
            errorProvider.SetError(sender as Control, "");
            if (phone.Length > 0)
            {
                String valid = validPhone(phone);
                if (!valid.Equals("Valid"))
                {
                    errorProvider.SetError(sender as Control, valid);
                }
            }
        }

        private String validPhone(String phone)
        {
            var rgxPhone = new Regex(@"^((84)|0)\d{9}$");
            if (phone.Length == 0) return "Phone can not be empty!";
            if (rgxPhone.IsMatch(phone)) return "Valid";
            return "Invalid phone number!\nPhone format: 84|0xxxxxxxxx, x is Digit!";
        }

        private String validIdentityNo(String identityNo)
        {
            var rgxIdentityNo = new Regex(@"^\d{12}$");
            if (identityNo.Length == 0) return "Identity number can not be empty!";
            if (rgxIdentityNo.IsMatch(identityNo)) return "Valid";
            return "Invalid identity number!\nIdentity number format:xxxxxxxxxxxx (12 digits)!";           
        }
    }
}