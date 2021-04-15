using System;
using System.Windows.Forms;

namespace Lab4_More
{
    public partial class EX5_StudentManage : Form
    {
        public EX5_StudentManage()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string student = txtName.Text;
            if (student.Equals(""))
            {
                MessageBox.Show("Chưa nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lbClassA.Items.Add(txtName.Text);
                txtName.Text = "";
            }
            txtName.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbClassA);
            selectedItems = lbClassA.SelectedItems;
            int n = lbClassA.SelectedItems.Count;
            for (int j = n - 1; j >= 0; j--)
                lbClassA.Items.Remove(selectedItems[j]);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbClassA);
            selectedItems = lbClassA.SelectedItems;
            int n = lbClassA.SelectedItems.Count;
            for (int i = 0; i < n; i++)
                lbClassB.Items.Add(lbClassA.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lbClassA.Items.Remove(selectedItems[j]);
        }

        private void btnMoveAllR_Click(object sender, EventArgs e)
        {
            int n = lbClassA.Items.Count;
            for (int i = 0; i < n; i++)
                lbClassB.Items.Add(lbClassA.Items[i].ToString());
            lbClassA.Items.Clear();
        }

        private void btnMoveAllL_Click(object sender, EventArgs e)
        {
            int n = lbClassB.Items.Count;
            for (int i = 0; i < n; i++)
                lbClassA.Items.Add(lbClassB.Items[i].ToString());
            lbClassB.Items.Clear();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lbClassB);
            selectedItems = lbClassB.SelectedItems;
            int n = lbClassB.SelectedItems.Count;
            for (int i = 0; i < n; i++)
                lbClassA.Items.Add(lbClassB.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lbClassB.Items.Remove(selectedItems[j]);
        }
    }
}