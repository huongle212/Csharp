using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_W8_DemoCSDL
{
    public partial class Bai1_3_TruyvanCSDL : Form
    {
        private SqlConnection conn = null;
        private string strconn = "Data Source=Mit;Initial Catalog=PRN292_QLSinhVien;Integrated Security=true";

        public Bai1_3_TruyvanCSDL()
        {
            InitializeComponent();
        }

        private void btnXemTt_Click(object sender, EventArgs e)
        {
            txtMalop.Text = "";
            txtNam.Text = "";
            txtTenlop.Text = "";
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from Lop where Malop='" + txtInputMalop.Text + "'";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtMalop.Text = reader.GetString(0);
                    txtTenlop.Text = reader.GetString(1);
                    txtNam.Text = reader.GetInt32(2).ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXemDstv_Click(object sender, EventArgs e)
        {
            lsvSinhvien.Items.Clear();
            try
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from SinhVien where Malop='" + txtInputMalop.Text + "'";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string masv = reader.GetString(0);
                    string ten = reader.GetString(1);
                    string lop = reader.GetString(2);
                    ListViewItem item = new ListViewItem(masv);
                    item.SubItems.Add(ten);
                    item.SubItems.Add(lop);
                    lsvSinhvien.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
