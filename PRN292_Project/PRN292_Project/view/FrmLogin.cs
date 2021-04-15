using PRN292_Project.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class FrmLogin : Form
    {
        private SqlConnection conn = null;

        FrmHome frmHome;

        public FrmLogin()
        {
            InitializeComponent();
            picHidePass.Hide();
            btnLogin.FlatAppearance.BorderSize = 0;
        }

        public FrmLogin(FrmHome frmHome) : this() => this.frmHome = frmHome;

        private void picClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picShowPass_Click(object sender, EventArgs e)
        {
            picShowPass.Hide();
            txtPassword.UseSystemPasswordChar = false;
            picHidePass.Show();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            picHidePass.Hide();
            txtPassword.UseSystemPasswordChar = true;
            picShowPass.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Staff staff = CheckLogin(username, password) as Staff;
            if (staff!=null)
            {
                if (frmHome != null) frmHome.CurUser = staff;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }else MessageBox.Show("Username or password incorrect!", "Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public object CheckLogin(string username, String password)
        {
            Staff staff = null;
            try
            {
                if (conn == null) conn = new SqlConnection(FrmHome.Strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from Staff where username=@username and password = @password";
                command.Connection = conn;
                // set parameter
                SqlParameter sqlpara1 = new SqlParameter("@username", SqlDbType.Char);
                sqlpara1.Value = username;
                command.Parameters.Add(sqlpara1);
                SqlParameter sqlpara2 = new SqlParameter("@password", SqlDbType.Char);
                sqlpara2.Value = password;
                command.Parameters.Add(sqlpara2);
                // execute command
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    String fullname = reader.GetString(2);
                    String role = reader.GetString(3);
                    staff = new Staff(username,password,fullname,role);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return staff;
        }
    }
}
