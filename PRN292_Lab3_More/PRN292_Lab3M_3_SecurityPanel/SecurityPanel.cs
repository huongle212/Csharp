using System;
using System.IO;
using System.Windows.Forms;

namespace PRN292_Lab3M_3_SecurityPanel
{
    public partial class SecurityPanel : Form
    {
        public SecurityPanel()
        {
            InitializeComponent();
        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            code += (sender as Button).Text;
            txtCode.Text = code;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string codeStr = txtCode.Text;
            if (codeStr.Length <= 1)
            {
                string log = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss tt") + "\t" + "Restricted access!";
                listLog.Items.Add(log);
                MessageBox.Show("Acess Denied!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int code = int.Parse(txtCode.Text);
                switch (code)
                {
                    case 1645:
                        display("Technicians");
                        break;
                    case 1689:
                        display("Technicians");
                        break;
                    case 8345:
                        display("Custodians");
                        break;
                    case 9998:
                        display("Scientist");
                        break;
                    default:
                        if (code >= 1006 && code <= 1008)
                        {
                            display("Scientist");
                        }
                        else
                        {
                            string log = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss tt") + "\t" + "Access denied!";
                            listLog.Items.Add(log);
                            MessageBox.Show("Acess Denied!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            txtCode.Text = "";
        }

        private void display(String str)
        {
            string log = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss tt") + "\t" + str;
            listLog.Items.Add(log);
            MessageBox.Show("Access Granted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                txtCode.Text = txtCode.Text + ch;
            }
            else if (ch == (char)Keys.Enter || ch==13)
                btnEnter_Click(sender, e);
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            saveLog();
            listLog.Items.Clear();
        }

        private void saveLog()
        {
            using (StreamWriter writetext = File.AppendText("log.txt"))
            {
                foreach (string i in listLog.Items)
                    writetext.WriteLine(i);
            }
        }

        private void SecurityPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveLog();
        }
    }
}