using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_W8_DemoCSDL
{
    public partial class Bai1_4_TruyvanCSDL : Form
    {
        private SqlConnection conn = null;
        private String strconn = "Data Source=Mit;Initial Catalog=PRN292_QLSinhVien;Integrated Security=true";

        public Bai1_4_TruyvanCSDL()
        {
            InitializeComponent();
        }

        private void Bai1_4_TruyvanCSDL_Load(object sender, EventArgs e)
        {
            lsLop.ClearSelected();
            try
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from Lop";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string malop = reader.GetString(0);
                    string ten = reader.GetString(1);
                    int nam = reader.GetInt32(2);
                    string line = malop + "-" + ten + "-" + nam;
                    lsLop.Items.Add(line);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lsLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvSinhvien.Items.Clear();
            if (lsLop.SelectedIndex == -1) return;
            string line = lsLop.SelectedItem.ToString();
            string[] classInfor = line.Split('-');
            string malop = classInfor[0];
            try
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                // command
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from SinhVien where malop=@malop"; // use parameter
                command.Connection = conn;
                // set parameter
                SqlParameter sqlpara = new SqlParameter("@malop", SqlDbType.Char);
                sqlpara.Value = malop;
                command.Parameters.Add(sqlpara);
                // execute command
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string masv = reader.GetString(0);
                    string ten = reader.GetString(1);
                    ListViewItem item = new ListViewItem(masv);
                    item.SubItems.Add(ten);
                    item.SubItems.Add(malop);
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
