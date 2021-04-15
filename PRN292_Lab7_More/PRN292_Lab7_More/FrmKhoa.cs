using System;
using System.Windows.Forms;

namespace PRN292_Lab7_More
{
    public partial class FrmKhoa : Form
    {
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.khoaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pRN292_QLSV_Lab7DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.ToString()}");
            }
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_QLSV_Lab7DataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.pRN292_QLSV_Lab7DataSet.Khoa);

        }
    }
}
