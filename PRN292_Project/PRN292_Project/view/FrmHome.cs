using PRN292_Project.Model;
using PRN292_Project.view.User_control;
using PRN292_Project.view;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class FrmHome : Form
    {
        private SqlConnection conn = null;
        private static String strconn = "";
        private int logId = -1;
        private UcCheckin frmCheckin=null;
        private UcGuest frmGuest = null;
        private UcRoom frmRoom = null;
        private UcStaff frmStaff = null;
        private Staff curUser;
        internal Staff CurUser { get => curUser; set => curUser = value; }
        public static string Strconn { get => strconn; set => strconn = value; }

        public FrmHome()
        {
            InitializeComponent();
            btnCheckin.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnGuest.FlatAppearance.BorderSize = 0;
            btnRoom.FlatAppearance.BorderSize = 0;
            btnStaff.FlatAppearance.BorderSize = 0;
            closeToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            thuNhoToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            profileToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
        }

        //============================= Form ====================================
        private void FrmHome_Load(object sender, EventArgs e)
        {
            configConnectionString();
            var frmLogin = new FrmLogin(this);
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                if (CurUser.Role.Equals("Staff"))
                {
                    btnStaff.Visible = false;
                    staffToolStripMenuItem1.Visible = false;
                    staffToolStripMenuItem.Visible = false;
                }
                else
                {
                    btnStaff.Visible = true;
                    staffToolStripMenuItem1.Visible = true;
                    staffToolStripMenuItem.Visible = true;
                }
                this.Show();
                timer.Start();
                timer_Tick(null, null);
                logId = createHistoryLogin(curUser.Username);
                profileToolStripMenuItem.Text = CurUser.getDisplayName();
                // Clean resource
                frmLogin.Dispose();
                frmLogin = null; // xoa o GC
            }else this.Close();
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logout(logId);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLblDate.Text =DateTime.Now.ToString("HH:mm:ss dd-MM-yyyy");
        }
        //--------------------------- .end Form ----------------------------------

        //============================= Left Panel ====================================
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (frmCheckin == null) frmCheckin = new UcCheckin();
            frmCheckin.setTabSelected(0);
            if (pnCenter.Controls.Contains(frmCheckin))
            {
                frmCheckin.BringToFront();
                frmCheckin.Visible = true;
            }else{
                pnCenter.Controls.Add(frmCheckin);
                frmCheckin.Dock = DockStyle.Fill;
                frmCheckin.BringToFront();
                frmCheckin.Visible = true;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (frmCheckin == null) frmCheckin = new UcCheckin();
            frmCheckin.setTabSelected(1);
            if (pnCenter.Controls.Contains(frmCheckin))
            {
                frmCheckin.BringToFront();
                frmCheckin.Visible = true;
            }
            else
            {
                pnCenter.Controls.Add(frmCheckin);
                frmCheckin.Dock = DockStyle.Fill;
                frmCheckin.BringToFront();
                frmCheckin.Visible = true;
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            if (frmGuest == null) frmGuest = new UcGuest();
            if (pnCenter.Controls.Contains(frmGuest))
            {
                frmGuest.BringToFront();
                frmGuest.Visible = true;
            }
            else
            {
                pnCenter.Controls.Add(frmGuest);
                frmGuest.Dock = DockStyle.Fill;
                frmGuest.BringToFront();
                frmGuest.Visible = true;
            }
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (frmRoom == null) frmRoom = new UcRoom();
            if (pnCenter.Controls.Contains(frmRoom))
            {
                frmRoom.BringToFront();
                frmRoom.Visible = true;
            }
            else
            {
                pnCenter.Controls.Add(frmRoom);
                frmRoom.Dock = DockStyle.Fill;
                frmRoom.BringToFront();
                frmRoom.Visible = true;
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (frmStaff == null) frmStaff = new UcStaff();
            if (pnCenter.Controls.Contains(frmStaff))
            {
                frmStaff.BringToFront();
                frmStaff.Visible = true;
            }
            else
            {
                pnCenter.Controls.Add(frmStaff);
                frmStaff.Dock = DockStyle.Fill;
                frmStaff.BringToFront();
                frmStaff.Visible = true;
            }
        }
        //--------------------------- .end Left Panel ----------------------------------

        //=============================== Menu Strip =================================

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportRoom rpvRoom = new FrmReportRoom();
            rpvRoom.ShowDialog();
        }

        private void roomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnRoom_Click(null, null);
        }

        private void checkinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCheckin_Click(null, null);
        }

        private void checkoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCheckout_Click(null, null);
        }

        private void guestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnGuest_Click(null, null);
        }

        private void listStaffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStaff_Click(null, null);
        }

        private void historyLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStaff_Click(null, null);
        }
            private void checkInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmReportCheckin report = new FrmReportCheckin();
            report.ShowDialog();
        }

        private void roomTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportRoomType rpvRoom = new FrmReportRoomType();
            rpvRoom.ShowDialog();
        }

        private void guestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportGuest report = new FrmReportGuest();
            report.ShowDialog();
        }

        private void staffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportStaff report = new FrmReportStaff();
            report.ShowDialog();
        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurUser = null;
            Logout(logId);
            logId = -1;
            frmCheckin = new UcCheckin();
            frmGuest = new UcGuest();
            frmRoom = new UcRoom();
            frmStaff = new UcStaff();
            foreach (Control item in pnCenter.Controls)
                item.Dispose();
            this.Hide();
            FrmHome_Load(null, null);
        }
        //------------------------------- .end Menu Strip ------------------------------
        
        //=============================== Other =================================
        private int createHistoryLogin(String username)
        {
            int id = -1;
            try
            {
                if (conn == null) conn = new SqlConnection(Strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand("InsertHistoryLog",conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@staff",username));
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Direction = ParameterDirection.Output; //get output Stored procedure
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

        private bool Logout(int logId)
        {
            try
            {
                if (conn == null) conn = new SqlConnection(Strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand("Update HistoryLog set logoutTime=@curTime where id="+logId, conn);
                command.Parameters.Add(new SqlParameter("@curTime",DateTime.Now.ToString()));
                int rc=command.ExecuteNonQuery();
                return rc > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void configConnectionString()
        {
            try
            {
                using (StreamReader file = new StreamReader("config.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        Strconn += line;
                    }
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //=============================== .end Other =================================
    }
}
