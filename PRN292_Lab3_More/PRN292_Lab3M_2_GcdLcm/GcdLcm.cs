using System;
using System.Windows.Forms;

namespace PRN292_Lab3M_2_GcdLcm
{
    public partial class GcdLcm : Form
    {
        private int mode = 0;

        public GcdLcm()
        {
            InitializeComponent();
            txtA.Select();
        }

        public int Mode { get => mode; set => mode = value; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you to exit program?";
            string title = "Exit";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if(result==DialogResult.Yes) Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResult.Text = "";
            rdBtnGcd.Checked = false;
            rdBtnLcm.Checked = false;
            mode = 0;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            if (mode == 0)
            {
                MessageBox.Show("Please choose GCD/LCM before click Result!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int a, b;
                try
                {
                    a = int.Parse(txtA.Text);
                }catch(Exception ex)
                {
                    MessageBox.Show("Detail: Invalid A! Please input an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtA.Focus();
                    return;
                }
                try
                {
                    b = int.Parse(txtB.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detail: Invalid B! Please input an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtA.Focus();
                    return;
                }
                int rs;
                if (mode == 1) rs = GCD(a, b);
                else rs = LCM(a, b);
                txtResult.Text = rs.ToString();
            }
        }

        private int GCD(int a,int b)
        {
            if (a == 0) return b;
            return GCD(b % a, a);
        }

        private int LCM(int a, int b)
        {
            return (a*b)/GCD(a,b);
        }

        private void rdBtnGcd_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void rdBtnLcm_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
        }
    }
}