using System;
using System.Windows.Forms;

namespace Sum2Num
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
            txtNum1.Select(); // focus to txtNum1
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1); // or this.Close()
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtSum.Text = "";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            try
            {
               n1 = int.Parse(txtNum1.Text.Trim());
                
            }catch(Exception ex)
            {
                MessageBox.Show("Number 1 is invalid!","Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int n2 = 0;
            try
            {
                n2= int.Parse(txtNum2.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Number 2 is invalid!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int sum = (n1 + n2);
            txtSum.Text = sum.ToString();
        }
    }
}