using System;
using System.Windows.Forms;

namespace PRN292_Lab7_More
{
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sinhVienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pRN292_QLSV_Lab7DataSet);
            }catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.ToString()}");
            }
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_QLSV_Lab7DataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.pRN292_QLSV_Lab7DataSet.SinhVien);

        }
    }
}
