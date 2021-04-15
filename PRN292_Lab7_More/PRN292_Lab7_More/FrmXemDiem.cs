using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Lab7_More
{
    public partial class FrmXemDiem : Form
    {
        public FrmXemDiem()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRN292_QLSV_Lab7DataSet);

        }

        private void sinhVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRN292_QLSV_Lab7DataSet);
        }

        private void FrmXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_QLSV_Lab7DataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.pRN292_QLSV_Lab7DataSet.SinhVien);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy chuỗi connectionstring từ app.config
                string conn = global::PRN292_Lab7_More.Properties.Settings.Default.PRN292_QLSV_Lab7ConnectionString;
                string str;
                // truy vấn lấy điểm các môn học của SV có mã số được chọn
                str = string.Format("Select [KetQua].MaMH,TenMH, Diem From KetQua,MonHoc where [KetQua].MaMH =[MonHoc].MaMH AND MaSV = '{0}'", cbxMaSV.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                // đổ vào dataset
                adapter.Fill(ds);
                // hiển thị ra DataGridView
                dataGridView1.DataSource = ds.Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.ToString()}");
            }
        }
    }
}
