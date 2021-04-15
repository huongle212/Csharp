using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_W8_DemoCSDL
{
    public partial class Bai1_2_TruyvanCSDL : Form
    {
        private SqlConnection conn = null;
        private string strconn = "Data Source=Mit;Initial Catalog=PRN292_QLSinhVien;Integrated Security=true";

        public Bai1_2_TruyvanCSDL()
        {
            InitializeComponent();
        }

        private void btnTinhsl_Click(object sender, EventArgs e)
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
                lbKetqua.Text = kq.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: \n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
