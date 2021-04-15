using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRN292_Lab5_More
{
    public partial class Ex3_Nhanvien : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public Ex3_Nhanvien()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                ListViewItem lvi = lsvEmployee.Items.Add(txtName.Text);
                lvi.SubItems.Add(dtpDob.Value.ToShortDateString());
                lvi.SubItems.Add(txtAddress.Text);
                lvi.SubItems.Add(txtPhone.Text);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lsvEmployee.SelectedItems;
            if (selectedItems.Count > 0)
            {
                if (validData())
                {
                    selectedItems[0].SubItems[0].Text = txtName.Text;
                    selectedItems[0].SubItems[1].Text = dtpDob.Value.ToShortDateString();
                    selectedItems[0].SubItems[2].Text = txtAddress.Text;
                    selectedItems[0].SubItems[3].Text = txtPhone.Text;
                }
            }
            else
                MessageBox.Show("Chưa chọn nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedView = lsvEmployee.SelectedItems;
            if (selectedView.Count > 0)
            {
                lsvEmployee.Items.Remove(selectedView[0]);
            }
            else
                MessageBox.Show("Xin vui lòng chọn nhân viên muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lsvEmployee.SelectedItems;
            if (selectedItems.Count > 0)
            {
                txtName.Text = selectedItems[0].SubItems[0].Text;
                dtpDob.Text = selectedItems[0].SubItems[1].Text;
                txtAddress.Text = selectedItems[0].SubItems[2].Text;
                txtPhone.Text = selectedItems[0].SubItems[3].Text;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Control ctrPhone = (Control)sender;
            string phone = ctrPhone.Text;
            this.errorProvider.SetError(ctrPhone, "");
            if (phone.Length > 0)
            {
                Regex regex = new Regex(@"^\+?((84)|0)\d{9}$");
                Match match = regex.Match(phone);
                if (!match.Success)
                    this.errorProvider.SetError(ctrPhone, "Số điện thoại không hợp lệ!");
            }
        }

        private bool validData()
        {
            bool valid = true;
            String msg = "Xin vui lòng điền đầu đủ thông tin!";
            if (!ckEmpty(txtName.Text))
            {
                this.errorProvider.SetError(txtName as Control, "Họ và tên không được rỗng!");
                valid = false;
            }
            if (!ckEmpty(txtAddress.Text))
            {
                this.errorProvider.SetError(txtAddress as Control, "Địa chỉ không được rỗng!");
                valid = false;
            }
            if (!ckEmpty(txtPhone.Text))
            {
                this.errorProvider.SetError(txtPhone as Control, "Số điện thoại không được rỗng!");
                valid = false;
            }
            else
            {
                Regex regex = new Regex(@"^\+?((84)|0)\d{9}$");
                Match match = regex.Match(txtPhone.Text);
                if (!match.Success)
                {
                    if (valid) msg = "Số điện thoại không hợp lệ!";
                    this.errorProvider.SetError(txtPhone as Control, "Số điện thoại không hợp lệ!");
                    valid = false;
                }
            }
            if (!valid)
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return valid;
        }

        private bool ckEmpty(string check)
        {
            if (string.IsNullOrWhiteSpace(check))
                return false;
            return true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            this.errorProvider.SetError(sender as Control, "");
        }
    }
}
