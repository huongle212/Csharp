using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_More
{
    public partial class Ex4_Thaotacso : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Ex4_Thaotacso()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            Control ctrInt = (Control)sender;
            this.errorProvider.Clear();
            string num= ctrInt.Text;
            if (num.Length > 0)
            {
                try
                {
                    int.Parse(num);
                }
                catch(Exception ex)
                {
                    this.errorProvider.SetError(ctrInt, "Vui lòng nhập số nguyên");
                }                    
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lstResult.Items.Add(txtNum.Text);
                txtNum.Text = "";
            }
            txtNum.Focus();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            lstResult.ClearSelected();
            int n = lstResult.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(lstResult.Items[i].ToString());
                lstResult.Items[i] = num + 2;
            }
        }

        private void btnFirstEvenNum_Click(object sender, EventArgs e)
        {
            lstResult.ClearSelected();
            int n = lstResult.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(lstResult.Items[i].ToString());
                if (num < 0) num = -num;
                if (num % 2 == 0)
                {
                    lstResult.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnLastOddNum_Click(object sender, EventArgs e)
        {
            lstResult.ClearSelected();
            int n = lstResult.Items.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                int num = int.Parse(lstResult.Items[i].ToString());
                if (num < 0) num = -num;
                if (num % 2 == 1)
                {
                    lstResult.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnDelSelectedNum_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstResult);
            selectedItems = lstResult.SelectedItems;
            int n = selectedItems.Count;
            for (int j = n - 1; j >= 0; j--)
                lstResult.Items.Remove(selectedItems[j]);
        }

        private void btnDelFirstNum_Click(object sender, EventArgs e)
        {
            lstResult.Items.RemoveAt(0);
        }

        private void btnDelLastNum_Click(object sender, EventArgs e)
        {
            lstResult.Items.RemoveAt(lstResult.Items.Count-1);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex4_Thaotacso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
