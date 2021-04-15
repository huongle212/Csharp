using System;
using System.Windows.Forms;

namespace PRN292_PE
{
    public partial class FrmHome : Form
    {
        private static string connectString;

        public static string ConnectString { get => connectString; set => connectString = value; }

        public FrmHome()
        {
            InitializeComponent();
            ConnectString = System.IO.File.ReadAllText(@"AppConfig.txt");
        }

        private void datetimeStatus_Click(object sender, EventArgs e)
        {
            datetimeStatus.Text = DateTime.Now.ToString("hh:mm:ss tt dd-MM-yyyy");
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCapnhatBD frmCapnhatBD = new FrmCapnhatBD();
            frmCapnhatBD.ShowDialog();
        }

        private void timkiemTheoTenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimBD frmTimBD = new FrmTimBD();
            frmTimBD.ShowDialog();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            datetimeStatus.Text = DateTime.Now.ToString("hh:mm:ss tt dd-MM-yyyy");
        }
    }
}
