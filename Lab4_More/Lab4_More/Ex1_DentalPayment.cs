using System;
using System.Windows.Forms;

namespace Lab4_More
{
    public partial class Ex1_DentalPayment : Form
    {
        public Ex1_DentalPayment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            GetPay();
        }

        private void GetPay()
        {
            string cusName = txtName.Text;
            if (cusName.Equals(""))
            {
                MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Text = "";
            }
            else
            {
                int total = 0;
                if (chkClean.Checked)
                    total += 100000;
                if (chkWhiten.Checked)
                    total += 1200000;
                if (chkXRay.Checked)
                    total += 200000;
                total += int.Parse(numFilling.Value.ToString()) * 80000;
                txtTotal.Text = total.ToString();
            }
        }

    }
}
