using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class UcStaff : UserControl
    {
        private SqlConnection conn1 = null;
        int rowStaffEdit;
        ErrorProvider errorProvider = new ErrorProvider();

        public UcStaff()
        {
            InitializeComponent();     
        }

        private void UcStaff_Load(object sender, EventArgs e)
        {         
            DateTime date = DateTime.Now.AddDays(1);
            datetimeFrom.MaxDate = date;
            date =date.AddDays(DateTime.DaysInMonth(date.Year, date.Month) - date.Day);
            datetimeTo.MaxDate = date;
            ListStaff(this.dgvStaff);
            ListHistoryLog(this.dgvHistoryLogin);
            btnCancel_Click(null, null);
        }

        //======================================== TAB Staff ========================================
        private void dgvStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                dgvStaff.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            if (selectedIndex>-1 && selectedIndex < dgvStaff.Rows.Count - 1)
            {
                DataGridViewRow row = dgvStaff.Rows[selectedIndex]; 
                txtFullname.Text = row.Cells[2].Value.ToString();
                cbRole.SelectedItem = row.Cells[3].Value;
                if (e.ColumnIndex == 4)
                {
                    errorProvider.SetError(txtPassword as Control, "");
                    errorProvider.SetError(txtUsername as Control, "");
                    rowStaffEdit = selectedIndex;
                    btnAdd.Visible = false;
                    btnDelete.Visible = true;
                    btnDelete.Enabled = !row.Cells[3].Value.Equals("Admin");
                    cbRole.Enabled = !(row.Cells[3].Value.Equals("Admin")&&row.Cells[0].Value.Equals("admin"));
                    btnUpdate.Visible = true;
                    btnCancel.Visible = true;
                    txtUsername.Enabled = false;
                    txtUsername.Text = row.Cells[0].Value.ToString();
                    txtPassword.Text = row.Cells[1].Value.ToString();
                }
                else if (rowStaffEdit == -1)
                {
                    txtUsername.Text = row.Cells[0].Value.ToString();
                    txtPassword.Text = row.Cells[1].Value.ToString();
                }                   
            }
            else if (rowStaffEdit == -1)
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtFullname.Text = "";
                    cbRole.SelectedIndex = 0;
                }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            String password = txtPassword.Text;
            errorProvider.SetError(sender as Control, "");
            if (password.Length > 0)
            {
                String valid = validPassword(password);
                if (!valid.Equals("valid"))
                {
                    errorProvider.SetError(sender as Control, valid);
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            String uname = txtUsername.Text;
            errorProvider.SetError(sender as Control, "");
            if (uname.Length > 0)
            {
                String valid = validUsername(uname);
                if (!valid.Equals("valid"))
                {
                    errorProvider.SetError(sender as Control, valid);
                }
            }
        }

        private void txtKeywordStaff_TextChanged(object sender, EventArgs e)
        {

            String keyword = txtKeywordStaff.Text.Trim();
            dgvStaff.Rows.Clear();
            try
            {
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                String strCmd = $"Select * from Staff where username like N'%{keyword}%' or fullname like N'%{keyword}%' or role like N'%{keyword}%'";
                SqlCommand command = new SqlCommand(strCmd, conn1);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dgvStaff.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), "Edit");
                }
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picShowPass_Click(object sender, EventArgs e)
        {
            picShowPass.Hide();
            txtPassword.UseSystemPasswordChar = false;
            picHidePass.Show();
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            picHidePass.Hide();
            txtPassword.UseSystemPasswordChar = true;
            picShowPass.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPassword as Control, "");
            errorProvider.SetError(txtUsername as Control, "");
            picHidePass.Visible = false;
            picShowPass.Visible = true;
            rowStaffEdit = -1;
            txtUsername.Text = "";
            txtUsername.Enabled = true;
            txtPassword.Text = "";
            txtFullname.Text = "";
            cbRole.SelectedIndex = 0;
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                SqlCommand command = new SqlCommand("Delete from Staff where username=@username", conn1);
                SqlParameter sqlPara = new SqlParameter("@username", txtUsername.Text);
                command.Parameters.Add(sqlPara);
                int result = command.ExecuteNonQuery();
                conn1.Close();
                if (result > 0)
                {
                    MessageBox.Show("Delete a staff successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListStaff(dgvStaff);
                    btnCancel_Click(null, null);
                }
                else MessageBox.Show("No staff is deleted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete a staff failed!\nError: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String rs = validPassword(txtPassword.Text);
                if (txtFullname.Text.Length == 0) throw new Exception("Fullname is required!");
                if (!rs.Equals("valid")) throw new Exception(rs);
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn1;
                command.CommandText = $"Update Staff set fullname='{txtFullname.Text}', password='{txtPassword.Text}', " +
                    $"role='{cbRole.SelectedItem as String}' where username='{txtUsername.Text}'";
                int result = command.ExecuteNonQuery();
                conn1.Close();
                if (result > 0)
                {
                    ListStaff(dgvStaff);
                }
                MessageBox.Show("Update a staff successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show("Update a staff failed!\nError: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String rs = validUsername(txtUsername.Text);
                if (!rs.Equals("valid")) throw new Exception(rs);
                rs = validPassword(txtPassword.Text);
                if (!rs.Equals("valid")) throw new Exception(rs);
                if (txtFullname.Text.Trim().Length == 0) throw new Exception("Fullname can not be empty!");
                if (checkUsernameExist(txtUsername.Text)) throw new Exception("Username already exists!");
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn1;
                command.CommandText = $"insert into Staff values ('{txtUsername.Text}','{txtPassword.Text}','{txtFullname.Text}','{cbRole.SelectedItem as String}')";
                int result = command.ExecuteNonQuery();
                conn1.Close();
                if (result > 0)
                {
                    ListStaff(dgvStaff);
                    btnCancel_Click(null, null);
                }
                MessageBox.Show("Add a staff successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add a staff failed!\nError: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnItemTableStaffDeleteRow_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvStaff.SelectedRows;
            if (selectedRows.Count == 0) return;
            String userDelete="('";
            foreach (DataGridViewRow row in selectedRows)
            {
                if (checkAdmin(row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("You do not have permission to delete the administrator!");
                    return;
                }
                userDelete += row.Cells[0].Value+"','";
            }
            userDelete = userDelete.Substring(0, userDelete.Length-2)+")";
            try
            {
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                SqlCommand command = new SqlCommand($"Delete from staff where username in {userDelete}", conn1);
                int result = command.ExecuteNonQuery();
                conn1.Close();
                if (result > 0)
                {
                    ListStaff(dgvStaff);
                    btnCancel_Click(null, null);
                }
                MessageBox.Show("Delete staffs successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete staffs failed!\nError: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListStaff(DataGridView dgvStaff)
        {
            dgvStaff.Rows.Clear();
            try
            {
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                SqlCommand command = new SqlCommand("Select * from Staff", conn1);
                // execute command
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string uname = reader.GetString(0);
                    string pass = reader.GetString(1);
                    string fname = reader.GetString(2);
                    string role = reader.GetString(3);
                    dgvStaff.Rows.Add(uname, pass, fname, role, "Edit");
                }
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load data error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkUsernameExist(string username)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"Select * from Staff where username='{username}'",FrmHome.Strconn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0].Rows.Count > 0;
            }catch(Exception ex)
            {
                return false;
            }
        }

        private bool checkAdmin(string username)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"Select * from Staff where username='{username}' and role='Admin'", FrmHome.Strconn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0].Rows.Count > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //------------------------------------- .End Tab Staff -------------------------------------

        //===================================== Tab History Log =====================================
        private void btnViewAllHistoryLog_Click(object sender, EventArgs e)
        {
            ListHistoryLog(this.dgvHistoryLogin);
        }
        //search by username, fullname, role and loginTime
        private void btnHistorySearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (datetimeFrom.Value > datetimeTo.Value) throw new Exception("End time must be after begin time");
                dgvHistoryLogin.Rows.Clear();
                String key = txtKeywordHistory.Text;
                String from = datetimeFrom.Value.ToString();
                String to = datetimeTo.Value.ToString("yyyy-MM-dd HH:mm");
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "Select * from HistoryLog as h Left join Staff as s on s.username=h.staff" +
                    " where (h.staff like N'%" + key + "%' or s.fullname like N'%" + key + "%' " +
                    " or s.role like N'%" + txtKeywordHistory.Text + "%')" +
                    " and h.loginTime >= '"+from+"' and h.loginTime <= '"+to+"'";
                command.CommandType = CommandType.Text;
                command.Connection = conn1;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime? logoutTime = reader[3] as DateTime?;
                    dgvHistoryLogin.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(6), reader.GetDateTime(2), logoutTime);
                }
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListHistoryLog(DataGridView dgvHistoryLog)
        {
            dgvHistoryLog.Rows.Clear();
            try
            {
                if (conn1 == null) conn1 = new SqlConnection(FrmHome.Strconn);
                if (conn1.State == ConnectionState.Closed) conn1.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "Select * from HistoryLog as h Left join Staff as s on s.username=h.staff;";
                command.CommandType = CommandType.Text;
                command.Connection = conn1;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime? logoutTime = reader[3] as DateTime?;
                    dgvHistoryLog.Rows.Add(reader.GetInt32(0), reader.GetString(1),reader.GetString(6),reader.GetDateTime(2), logoutTime);
                }
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load data error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //---------------------------------- .End Tab History Log -----------------------------------

        //======================================== Validate ========================================
        private String validUsername(String username)
        {
            int minLen = 5;
            var hasOtherChar = new Regex(@"[^a-zA-Z\d]+"); // contain other char different digit, letter
            if (username.Length == 0) return "Username can not be empty!";
            if (username.Length < minLen) return "Length of username must greater than 4!";
            if (hasOtherChar.IsMatch(username)) return "Username contains only digits and letters in the English alphabet!";
            return "valid"; 
        }

        private String validPassword(String password)
        {
            int minLen = 6;
            var hasOtherChar = new Regex(@"[^a-zA-Z\d@_]+"); // contain other char different digit, letter, and '@_'
            if (password.Length == 0) return "Password can not be empty!";
            if (password.Length < minLen) return "Length of password must greater than 5!";
            if (hasOtherChar.IsMatch(password)) return "Password contains only digits, letters in the English alphabet, and '@_'!";
            return "valid";
        }

        private void txtFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='@'))
                e.Handled = true;
        }
    }
}
