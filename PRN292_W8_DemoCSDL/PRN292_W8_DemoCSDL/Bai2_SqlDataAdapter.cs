using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_W8_DemoCSDL
{
    public partial class Bai2_SqlDataAdapter : Form
    {
        private String strcon = "Data Source=Mit;Initial Catalog=PRN292_QLSinhVien;Integrated Security=true";
        private int vitri = -1;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public Bai2_SqlDataAdapter()
        {
            InitializeComponent();
        }

        private void Bai2_SqlDataAdapter_Load(object sender, EventArgs e)
        {
            //khởi tạo SqlDataAdapter
            adapter = new SqlDataAdapter("Select * from SinhVien", strcon);
            //tạo DataSet
            ds = new DataSet();
            //sử dụng SqlCommandBuilder để thêm, sửa, xóa dữ liệu
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //đưa dữ liệu từ adater là 1 bảng vào DataSet
            adapter.Fill(ds, "SinhVien");
            ckHienthiDssv.Checked = true;
            ckHienthiDssv_CheckedChanged(null, null);
        }

        private void ckHienthiDssv_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienthiDssv.Checked)
            {
                gvSinhvien.DataSource = ds.Tables[0];
            }
            else
            {
                gvSinhvien.DataSource = null;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            DataRow row = null;
            try
            {
                //Tạo dòng để thêm vào bảng SinhVien của DataSet
                row = ds.Tables[0].NewRow();
                //thêm dữ liệu cho hàng mới
                row[0] = txtMasv.Text;
                row[1] = txtTen.Text;
                row[2] = txtMalop.Text;
                ds.Tables[0].Rows.Add(row);
                //cập nhật lại adapter
                kq = adapter.Update(ds, "SinhVien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm một sinh viên thất bại!\nLỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (kq > 0) MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vitri == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kq = 0;
            try
            {
                DataRow row = ds.Tables["SinhVien"].Rows[vitri];
                //cập nhật hàng
                row.BeginEdit();
                row["Masv"] = txtMasv.Text;
                row["Hoten"] = txtTen.Text;
                row["Malop"] = txtMalop.Text;
                row.EndEdit();
                //cập nhật lại adapter
                kq = adapter.Update(ds.Tables["SinhVien"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại!\nLỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (kq > 0) MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vitri == -1) return;
            int kq = 0;
            try
            {
                DataRow row = ds.Tables["SinhVien"].Rows[vitri];
                row.Delete(); // xóa hàng
                //cập nhật lại adapter
                kq = adapter.Update(ds.Tables["SinhVien"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!\nLỗi: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (kq > 0) MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            if (vitri == -1)
            {
                MessageBox.Show("Không có dòng nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            txtMasv.Text = row[0].ToString();
            txtTen.Text = row["Hoten"].ToString();
            txtMalop.Text = row[2].ToString();
        }
    }
}
