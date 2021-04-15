using System;
using System.IO;
using System.Windows.Forms;

namespace Lab4_More
{
    public partial class EX2_ : Form
    {
        int total = 0;
        int noFill = 0;
        bool isChanged = false;
        int clean, whitening, xRay, filling;

        public int Total { get => total; set => total = value; }
        public int NoFill { get => noFill; set => noFill = value; }
        public bool IsChanged { get => isChanged; set => isChanged = value; }
        public int Clean { get => clean; set => clean = value; }
        public int Whitening { get => whitening; set => whitening = value; }
        public int XRay { get => xRay; set => xRay = value; }
        public int Filling { get => filling; set => filling = value; }
       
        public EX2_()
        {
            InitializeComponent();
        }

        private void EX2__FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IsChanged)
                {
                    if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        btnSave_Click(null, null);
                }
            }
            else e.Cancel = true;
        }

        private void chkClean_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClean.Checked)
                Total += Clean;
            else Total -= Clean;
            txtTotal.Text = Total.ToString("##,#0") + " VND";
        }

        private void chkWhiten_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWhiten.Checked)
                Total += Whitening;
            else Total -= Whitening;
            txtTotal.Text = Total.ToString("##,#0") + " VND";
        }

        private void chkXRay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXRay.Checked)
                Total += XRay;
            else Total -= XRay;
            txtTotal.Text = Total.ToString("##,#0") + " VND";
        }

        private void numFilling_ValueChanged(object sender, EventArgs e)
        {
            int newNoFill = int.Parse(numFilling.Value.ToString());
            Total += (newNoFill- NoFill) * Filling;
            txtTotal.Text = Total.ToString("##,#0") + " VND";
            NoFill = newNoFill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            string cusName = txtName.Text.Trim();
            if (cusName.Length == 0)
            {
                showMsg("Chưa nhập tên khách hàng!");
                txtName.Focus();
            }
            else
            {
                if (Total == 0)
                {
                    if (chkClean.Checked || chkWhiten.Checked || chkXRay.Checked
                        || NoFill > 0)
                    {
                        showMsg("Bạn được sử dụng dịch vụ miễn phí!");
                        Payment(cusName);
                    }
                    else showMsg("Bạn phải chọn dịch vụ trước khi thanh toán!");
                }
                else
                {
                    Payment(cusName);
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveDialog.FileName);
            }
            IsChanged = false;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    btnSave_Click(null, null);
            }
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                lstBill.Items.Clear();
                using (StreamReader sr = new StreamReader(file.OpenFile()))
                {
                    string line;
                    // Read and display lines from the file until the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        lstBill.Items.Add(line);
                    }
                }
            }
        }

        private void showMsg(String message)
        {
            MessageBox.Show(message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Payment(String cusName)
        {
            string format = "##,#0";
            lstBill.Items.Add($"{cusName} - {Total.ToString(format)} VND");
            IsChanged = true;
            chkClean.Checked = false;
            chkWhiten.Checked = false;
            chkXRay.Checked = false;
            numFilling.Value = 0;
            NoFill = 0;
            Total = 0;
            txtName.Text = "";
            txtTotal.Text = "";
        }

        private void SaveFile(string filename)
        {
            StreamWriter writeText = new StreamWriter(filename);
            using (writeText)
            {
                foreach (string i in lstBill.Items)
                    writeText.WriteLine(i);
            }
            IsChanged = false;
            writeText.Close();
        }

        private void EX2__Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("Ex2_DonGia.txt");
            foreach(string line in lines)
            {
                string[] values = line.Split('|');
                int price = int.Parse(values[2]);
                if(values[1].Equals("Cạo vôi"))
                {
                    Clean = price;
                    lblCleanCost.Text = price.ToString("##,#0") + " VND";
                }else if(values[1].Equals("Tẩy trắng"))
                {
                    Whitening = price;
                    lblWhitenCost.Text = price.ToString("##,#0") + " VND";
                }else if (values[1].Equals("Chụp hình răng"))
                {
                    XRay = price;
                    lblXRayCost.Text = price.ToString("##,#0") + " VND";
                }else if (values[1].Equals("Trám răng"))
                {
                    Filling = price;
                    lblFillCost.Text = price.ToString("##,#0") + " VND/cái";
                }
            }
        }
    }
}
