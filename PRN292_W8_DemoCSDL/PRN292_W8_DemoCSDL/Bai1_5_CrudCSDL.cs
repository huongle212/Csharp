using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_W8_DemoCSDL
{
    public partial class Bai1_5_CrudCSDL : Form
    {
        private SqlConnection conn = null;
        private string strconn = "Data Source=Mit;Initial Catalog=PRN292_QLSinhVien;Integrated Security=true";
        private int result = -1;

        public Bai1_5_CrudCSDL()
        {
            InitializeComponent();
        }

        private void Bai1_5_CrudCSDL_Load(object sender, EventArgs e)
        {
            HienThiSinhvien();
        }

        //đưa nội dung 1 hàng được chọn từ listview sang textbox
        private void lsvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSinhvien.SelectedItems.Count > 0)
            {
                txtMasv.Text = lsvSinhvien.SelectedItems[0].SubItems[0].Text;
                txtTen.Text = lsvSinhvien.SelectedItems[0].SubItems[1].Text;
                txtMalop.Text = lsvSinhvien.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "insert into SinhVien (masv,hoten,malop) values (@masv,@ten,@malop)";
                SqlParameter para1 = new SqlParameter("@masv", txtMasv.Text);
                SqlParameter para2 = new SqlParameter("@ten", txtTen.Text);
                SqlParameter para3 = new SqlParameter("@malop", txtMalop.Text);
                command.Parameters.Add(para1);
                command.Parameters.Add(para2);
                command.Parameters.Add(para3);
                result = command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm một sinh viên thất bại!\nLỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (result > 0)
                HienThiSinhvien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "update SinhVien set hoten=@hoten, malop=@malop where masv=@masv";
                SqlParameter para1 = new SqlParameter("@masv", txtMasv.Text);
                SqlParameter para2 = new SqlParameter("@hoten", txtTen.Text);
                SqlParameter para3 = new SqlParameter("@malop", txtMalop.Text);
                command.Parameters.Add(para1);
                command.Parameters.Add(para2);
                command.Parameters.Add(para3);
                result = command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật một sinh viên thất bại!\nLỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (result > 0)
                HienThiSinhvien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "Delete from SinhVien where masv=@masv";
                SqlParameter para1 = new SqlParameter("@masv", txtMasv.Text);
                command.Parameters.Add(para1);
                result = command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa một sinh viên thất bại!\nLỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (result > 0)
            {
                HienThiSinhvien();
                txtMalop.Text = "";
                txtMasv.Text = "";
                txtTen.Text = "";
            }
        }

        private void HienThiSinhvien()
        {
            try
            {
                lsvSinhvien.Items.Clear();
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand("Select * from SinhVien", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string masv = reader.GetString(0);
                    string ten = reader.GetString(1);
                    string malop = reader.GetString(2);
                    ListViewItem item = new ListViewItem(masv);
                    item.SubItems.Add(ten);
                    item.SubItems.Add(malop);
                    lsvSinhvien.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
