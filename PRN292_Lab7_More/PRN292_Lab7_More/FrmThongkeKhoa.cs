using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Lab7_More
{
    public partial class FrmThongkeKhoa : Form
    {
        public FrmThongkeKhoa()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = global::PRN292_Lab7_More.Properties.Settings.Default.PRN292_QLSV_Lab7ConnectionString;
                string str= $"Select * from SinhVien where MaKhoa = '{cbxMakhoa.Text}'";
                SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.ToString()}");
            }
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRN292_QLSV_Lab7DataSet);
        }

        private void FrmThongkeKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_QLSV_Lab7DataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.pRN292_QLSV_Lab7DataSet.Khoa);

        }
    }
}
