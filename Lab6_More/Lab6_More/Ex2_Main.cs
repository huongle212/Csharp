using System;
using System.Windows.Forms;

namespace Lab6_More
{
    public partial class Ex2_Main : Form
    {
        Ex2_About frmAbout = new Ex2_About();

        public Ex2_Main()
        {
            InitializeComponent();
        }

        private void Ex2__Load(object sender, EventArgs e)
        {
            // Set the Parent Form of the Child window.
            frmAbout.MdiParent = this;
            // Display the new form.
            frmAbout.Show();
        }
    }
}
