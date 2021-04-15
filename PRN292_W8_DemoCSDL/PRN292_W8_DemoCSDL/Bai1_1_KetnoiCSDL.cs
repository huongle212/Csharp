using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_W8_DemoCSDL
{
    public partial class Bai1_1_KetnoiCSDL : Form
    {
        SqlConnection conn = null;
        string strconn = "database=PRN292_QLSinhVien;Server=Mit;User id=sa; password=sa";
        //c2: string strconn = "Data Source=Mit;Initial Catalog=PRN292_QLSinhVien;Integrated Security=true";
        //c3: string strconn = "Server=Mit;database=PRN292_QLSinhVien;User id=sa; password=sa";
        public Bai1_1_KetnoiCSDL()
        {
            InitializeComponent();
            enabledBtn(true);
        }

        private void btn_OpenConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                enabledBtn(false);
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại!\n" + ex.ToString());
            }
        }

        private void btn_CloseConnect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                enabledBtn(true);
                MessageBox.Show("Đã đóng kết nối SQL thành công!");
            }
        }

        private void enabledBtn(bool open)
        {
            btn_OpenConnect.Enabled = open;
            btn_CloseConnect.Enabled = !open;
        }

        private void btnTinhSLSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select count(*) from SinhVien";
                command.Connection = conn;
                //thực thi câu lệnh trả về 1 giá trị
                int kq = (int)command.ExecuteScalar();
                MessageBox.Show($"Tổng số sinh viên hiện có: {kq.ToString()}", "Kết quả");
                conn.Close();
                enabledBtn(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: \n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuanlySv_Click(object sender, EventArgs e)
        {
            Bai1_5_CrudCSDL quanlySinhVien = new Bai1_5_CrudCSDL();
            //quanlySinhVien.Show();//not block main form
            quanlySinhVien.ShowDialog(); // this will block the main form until the child is closed.
        }

        private void btnDsLop_Click(object sender, EventArgs e)
        {
            Bai1_4_TruyvanCSDL dsLop = new Bai1_4_TruyvanCSDL();
            dsLop.ShowDialog();
        }

        private void btnXemttlop_Click(object sender, EventArgs e)
        {
            Bai1_3_TruyvanCSDL ttLop = new Bai1_3_TruyvanCSDL();
            ttLop.ShowDialog();
        }
    }
}
