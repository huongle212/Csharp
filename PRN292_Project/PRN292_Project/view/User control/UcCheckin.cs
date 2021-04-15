using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class UcCheckin : UserControl
    {
        private SqlDataAdapter adapter = null;
        private DataSet dataSet = null;
        private SqlDataAdapter adapterGuest = null;
        private DataSet dataSetGuest = null;
        ErrorProvider errorProvider = new ErrorProvider();
        private bool firstCheckin=true;
        private bool firstCheckout = true;

        public UcCheckin()
        {
            InitializeComponent();
            btnCiSearchRoom.FlatAppearance.BorderSize = 0;
        }

        public void setTabSelected(int n)
        {
            tabControlCICO.SelectedIndex = n;
        }



        private void UcCheckin_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now.Date.AddDays(1);
            dtpCICheckoutTime.MinDate = now;
            string sql = "Select roomNo as [RoomNo], [type] As [Room Type],isVacant as Vacant, " +
                "CASE  WHEN isVacant = 1 THEN 'Check In' ELSE 'Check Out' END AS 'ACtion' from Room;";
            adapter = new SqlDataAdapter(sql, FrmHome.Strconn);
            dataSet = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataSet, "Room");
            adapterGuest = new SqlDataAdapter("Select * from Guest",FrmHome.Strconn);
            dataSetGuest = new DataSet();
            SqlCommandBuilder builderGuest = new SqlCommandBuilder(adapterGuest);
            adapterGuest.Fill(dataSetGuest, "Guest");
            this.roomTypeTableAdapter.Fill(this.pRN292_HotelDBDataSet.RoomType);
            this.roomTableAdapter.Fill(this.pRN292_HotelDBDataSet.Room);
            this.guestTableAdapter.Fill(this.pRN292_HotelDBDataSet.Guest);
            this.viewCheckinTableAdapter.Fill(this.pRN292_HotelDBDataSet.ViewCheckin);
            viewAllRoom(dgvRoom);
            clear();
            btnReset_Click(null,null);
            btnCOReset_Click(null, null);
        }

        private void viewAllRoom(DataGridView dataGridView)
        {
            try
            {
                dataGridView.DataSource = dataSet.Tables["Room"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCiSearchRoom_Click(object sender, EventArgs e)
        {
            tabControlCICO.SelectedIndex = 2;
        }

        private void cbxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLRAllRoomType.Checked = false;
            txtSearchRoomNo_TextChanged(null, null);
        }

        private void cbxVacant_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchRoomNo_TextChanged(null, null);
        }

        private void txtSearchRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxRoomType.SelectedValue == null)
                {
                    viewAllRoom(dgvRoom);
                    return;
                }
                string sql = "Select roomNo as [RoomNo], [type] As [Room Type],isVacant as Vacant, " +
                    "CASE  WHEN isVacant = 1 THEN 'Check In' ELSE 'Check Out' END AS 'Action' from Room " +
                    $"where roomNo like N'%{txtSearchRoomNo.Text}%'";
                if (!cbLRAllRoomType.Checked)
                    sql += $" and [type]={(int)cbxRoomType.SelectedValue}";
                int vacant = cbxVacant.SelectedIndex;
                if (vacant == 0 || vacant == 1)
                    sql += $" and isVacant={vacant}";
                SqlDataAdapter adap = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvRoom.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbLRAllRoomType_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchRoomNo_TextChanged(null, null);
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rIndex = e.RowIndex;
            if (rIndex < 0 || rIndex > dgvRoom.Rows.Count - 2)
                return;
            if (e.ColumnIndex == 3)
            {
                string action = dgvRoom.Rows[rIndex].Cells[3].Value.ToString();
                if (action.Equals("Check In"))
                {
                    cbxCIRoomNo.SelectedValue = dgvRoom.Rows[rIndex].Cells[0].Value.ToString();
                    cbxCIRoomType.SelectedValue = dgvRoom.Rows[rIndex].Cells[1].Value.ToString();
                    tabControlCICO.SelectedIndex = 0;
                }
                else
                {
                    tabControlCICO.SelectedIndex = 2;
                    cbxCORoomNo.Text = dgvRoom.Rows[rIndex].Cells[0].Value.ToString();
                    btnCheckOut_Click(null, null);
                }
            }
        }

        private void dtpCICheckoutTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan difference = dtpCICheckoutTime.Value - today;
            int days = (int)difference.TotalDays;
            txtCIDays.Text = days.ToString();
        }

        private void txtCIDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long total = int.Parse(txtCIDays.Text) * (long)int.Parse(txtCIRoomRate.Text);
                txtCISubTotal.Text = total.ToString() + " VND";
            }catch(Exception ex) {
                txtCISubTotal.Text = "0 VND";
            }
        }

        private void txtCIRoomRate_TextChanged(object sender, EventArgs e)
        {
            txtCIDays_TextChanged(null, null);
        }

        private void txtCIIdentityNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCIPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cbxCIGuestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxCIGuestID.SelectedIndex = -1;
            cbxCIGuestName.SelectedIndex = -1;         
            dtpCICheckoutTime.Value = DateTime.Now.Date.AddDays(1);
            ciNoAdult.Value = 0;
            ciNoAdult.Value = 0;
            cbxCIRoomType.SelectedIndex = -1;
            cbxCIRoomNo.SelectedIndex = -1;
            txtCIIdentityNo.Text = "";
            txtCIPhone.Text = "";
            txtCINoOccupancy.Text="";
            txtCIRoomRate.Text = "0";
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            String gId = cbxCIGuestID.Text;
            try
            {
                int guId = -1;
                string name = cbxCIGuestName.Text;
                if (name.Length == 0) throw new Exception("Guest name can not be empty!");
                string valid = validIdentityNo(txtCIIdentityNo.Text);
                if (!valid.Equals("Valid")) throw new Exception(valid);
                valid = validPhone(txtCIPhone.Text);
                if (!valid.Equals("Valid")) throw new Exception(valid);
                if (cbxCIRoomNo.Text.Length == 0) throw new Exception("You don't choose room!");
                else if (!checkRoomExist(cbxCIRoomNo.Text)) throw new Exception("Room doesn't exist!");
                else if(!checkRoomVacant(cbxCIRoomNo.Text)) throw new Exception("Room is in used!");
                int noAdult = (int)ciNoAdult.Value;
                int noChild = (int)ciNoChild.Value;
                int max = int.Parse(txtCINoOccupancy.Text)+2;
                if (noAdult +noChild == 0) throw new Exception("Minimum occupancy is 1!");
                if (noAdult + noChild > max) throw new Exception("Only allow 2 more occupants than the maximum!");
                if (gId.Length == 0)
                {
                    guId = createNewGuest(name, txtCIIdentityNo.Text, txtCIPhone.Text, "", true);
                }
                else guId = int.Parse(gId);
                int rs = createCheckin(guId,int.Parse(cbxCIRoomNo.Text),noAdult,noChild, dtpCICheckoutTime.Value);
                if (rs > 0)
                {
                    UcCheckin_Load(null, null);
                    MessageBox.Show("Checkin successfully!");
                }
                else MessageBox.Show("Checkin fail!");
            } 
            catch(Exception ex)
            {
                MessageBox.Show($"Check in fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            cbxVacant.SelectedIndex = 2;
            cbLRAllRoomType.Checked = true;
        }

        private void txtCIIdentityNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string iNo = txtCIIdentityNo.Text;
                DataRow[] dataRows = dataSetGuest.Tables["Guest"].Select($"identityNumber='{iNo}'");
                if (dataRows.Length == 0)
                {
                    cbxCIGuestID.SelectedIndex = -1;
                    return;
                }
                DataRow row = dataRows[0];
                cbxCIGuestID.SelectedValue=row[0].ToString();
                cbxCIGuestName.SelectedValue = row[1].ToString();
                txtCIPhone.Text = row[3].ToString();
            }
            catch (Exception ex) { }
           
        }

        private void txtCIIdentityNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            String iNo = txtCIIdentityNo.Text;
            errorProvider.SetError(sender as Control, "");
            if (iNo.Length > 0)
            {
                String valid = validIdentityNo(iNo);
                if (!valid.Equals("Valid"))
                {
                    errorProvider.SetError(sender as Control, valid);
                }
            }
        }

        private void txtCIPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            String phone = txtCIPhone.Text;
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

        public static int createNewGuest(string fullname, string identityNo, string phone, string address, bool gender)
        {
            int id = -1;
            try
            {
                SqlConnection conn = null;
                if (conn == null) conn = new SqlConnection(FrmHome.Strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand("InsertGuest", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@fullname", fullname));
                command.Parameters.Add(new SqlParameter("@identityNo", identityNo));
                command.Parameters.Add(new SqlParameter("@phone", phone));
                command.Parameters.Add(new SqlParameter("@address", address));
                command.Parameters.Add(new SqlParameter("@gender",gender));
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

        public static int createCheckin(int guestId, int roomNo, int adult, int child, DateTime expectCheckOutTime)
        {
            int id = -1;
            try
            {
                SqlConnection conn = null;
                if (conn == null) conn = new SqlConnection(FrmHome.Strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand("InsertCheckin", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@guestId",guestId));
                command.Parameters.Add(new SqlParameter("@roomNo", roomNo));
                command.Parameters.Add(new SqlParameter("@adult", adult));
                command.Parameters.Add(new SqlParameter("@child", child));
                command.Parameters.Add(new SqlParameter("@expectCheckoutTime",expectCheckOutTime));
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

        private bool checkRoomVacant(string roomNo)
        {
            try
            {
                return dataSet.Tables["Room"].Select($"roomNo={roomNo} and vacant=1").Length>0;
            }
            catch (Exception ex) {
                return false;
            }
            
        }

        private bool checkRoomExist(string roomNo)
        {
            try
            {
                return dataSet.Tables["Room"].Select($"roomNo={roomNo}").Length > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void btnCOReset_Click(object sender, EventArgs e)
        {
            txtCOGuestName.Text = "";
            txtCOIdentityNo.Text = "";
            txtCODays.Text = "";
            txtCOChild.Text = "0";
            txtCOAdult.Text = "0";
            txtCORoomRate.Text = "";
            txtCORoomType.Text = "";
            txtCOTotal.Text = "0 VND";
            dtpCICheckInTime.Value = DateTime.Now;
            dtpCOExpectCheckoutTime.Value = DateTime.Now;
            dtpCOCheckoutTime.Value = DateTime.Now;
            cbxCORoomNo.SelectedIndex = -1;
        }

        private void dtpCICheckInTime_ValueChanged(object sender, EventArgs e)
        {
            dtpCOCheckoutTime_ValueChanged(null, null);
        }

        private void txtCORoomRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long total = int.Parse(txtCODays.Text) * (long)int.Parse(txtCORoomRate.Text);
                txtCOTotal.Text = total.ToString() + " VND";
            }
            catch (Exception ex)
            {
                txtCISubTotal.Text = "0 VND";
            }
        }

        private void txtCODays_TextChanged(object sender, EventArgs e)
        {
            txtCORoomRate_TextChanged(null, null);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = cbxCORoomNo.Text;
                if (txt.Length == 0) throw new Exception("You don't choose room to checkout!");
                else if(!checkRoomExist(txt)) throw new Exception("Room doesn't exist!");
                else if (checkRoomVacant(txt)) throw new Exception("Room is vacant!");
                int rNo = int.Parse(txt);
                if (checkOut(rNo))
                {
                    UcCheckin_Load(null,null);
                    MessageBox.Show("Check out successfully!");
                }
                else
                    MessageBox.Show($"Check out fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check out fail! \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCORoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private bool checkOut(int roomNo)
        {
            try
            {
                SqlConnection conn = null;
                if (conn == null) conn = new SqlConnection(FrmHome.Strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand("CheckoutRoom", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@roomNo", roomNo));
                int rc = command.ExecuteNonQuery();
                conn.Close();
                return rc>0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void dtpCOCheckinTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            TimeSpan difference = today.Date - dtpCOCheckinTime.Value.Date;
            int days = (int)difference.TotalDays;
            if (days == 0) days++;
            txtCODays.Text = days.ToString();
        }

        private void dtpCOCheckoutTime_ValueChanged(object sender, EventArgs e)
        {
            dtpCICheckoutTime_ValueChanged(null,null);
        }

        private void tabControlCICO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlCICO.SelectedIndex==0 && firstCheckin)
            {
                btnReset_Click(null, null);
                firstCheckin = false;
            }else if(tabControlCICO.SelectedIndex == 1 && firstCheckout)
            {
                btnCOReset_Click(null, null);
                firstCheckout = false;
            }
        }
    }
}
