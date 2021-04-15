using PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace PRN292_Lab7_More
{
    public partial class FrmNhapDiem : Form
    {
        public FrmNhapDiem()
        {
            InitializeComponent();
        }

        private void FrmNhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_QLSV_Lab7DataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.pRN292_QLSV_Lab7DataSet.SinhVien);
            // TODO: This line of code loads data into the 'pRN292_QLSV_Lab7DataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.pRN292_QLSV_Lab7DataSet.MonHoc);
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                int d = int.Parse(txtDiem.Text);
                if (d < 0) throw new Exception("Điểm nhỏ hơn 0.");
                if (d >10) throw new Exception("Điểm lớn hơn 10.");
                KetQuaTableAdapter ketQuaTableAdapter = new KetQuaTableAdapter();
                int rc=ketQuaTableAdapter.Insert(cbxMasv.Text,cbxMamon.Text,d);
                if(rc>0) MessageBox.Show("Nhập điểm thành công!");
            }catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.ToString()}");
            }
        }
    }
}
