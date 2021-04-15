using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PRN292_PE
{
    public partial class FrmCapnhatBD : Form
    {
        SqlConnection conn = null;
        Regex maDia = new Regex(@"^[D]\d{4,}$", RegexOptions.IgnoreCase);

        public FrmCapnhatBD()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkMadiaExist(txtMadia.Text))
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                    return;
                try
                {
                    if (conn == null)
                        conn = new SqlConnection(FrmHome.ConnectString);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = $"Delete from dia where madia='{txtMadia.Text}'";
                    command.Connection = conn;
                    int rc = command.ExecuteNonQuery();
                    if (rc > 0)
                    {
                        MessageBox.Show("Xóa đĩa thành công!");
                    }
                    conn.Close();
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xóa đĩa không thành công! \n Lỗi: {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Mã đĩa không tồn tại!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validateInfo())
            {
                if (checkMadiaExist(txtMadia.Text))
                {
                    MessageBox.Show("Mã đĩa đã tồn tại!");
                }
                else
                {
                    try
                    {
                        if (conn == null)
                            conn = new SqlConnection(FrmHome.ConnectString);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.Text;
                        command.Connection = conn;
                        command.CommandText = "insert into dia(madia,tendia,theloai) values(@madia, @tendia,@theloai)";
                        SqlParameter sqlPara1 = new SqlParameter("@madia", txtMadia.Text);
                        command.Parameters.Add(sqlPara1);
                        SqlParameter sqlPara2 = new SqlParameter("@tendia", txtTendia.Text);
                        command.Parameters.Add(sqlPara2);
                        SqlParameter sqlPara3 = new SqlParameter("@theloai", txtTheloai.Text);
                        command.Parameters.Add(sqlPara3);
                        int rc = command.ExecuteNonQuery();
                        if (rc > 0)
                        {
                            MessageBox.Show("Thêm đĩa mới thành công!");
                        }
                        conn.Close();
                        reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Thêm đĩa mới không thành công! \n Lỗi: {ex.ToString()}");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validateInfo())
            {
                if (checkMadiaExist(txtMadia.Text))
                {
                    DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.No)
                        return;
                    try
                    {
                        if (conn == null)
                            conn = new SqlConnection(FrmHome.ConnectString);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.Text;
                        command.Connection = conn;
                        command.CommandText = "update dia set tendia=@tendia, theloai=@theloai where madia=@madia";
                        SqlParameter sqlPara1 = new SqlParameter("@madia", txtMadia.Text);
                        command.Parameters.Add(sqlPara1);
                        SqlParameter sqlPara2 = new SqlParameter("@tendia", txtTendia.Text);
                        command.Parameters.Add(sqlPara2);
                        SqlParameter sqlPara3 = new SqlParameter("@theloai", txtTheloai.Text);
                        command.Parameters.Add(sqlPara3);
                        int rc = command.ExecuteNonQuery();
                        if (rc > 0)
                        {
                            MessageBox.Show("Cập nhật đĩa thành công!");
                        }
                        conn.Close();
                        reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Cập nhật đĩa không thành công! \n Lỗi: {ex.ToString()}");
                    }
                }
                else
                {
                    MessageBox.Show("Mã đĩa không tồn tại!");
                }
            }
        }

        private bool validateInfo()
        {
            if (string.IsNullOrWhiteSpace(txtMadia.Text) || string.IsNullOrWhiteSpace(txtTendia.Text) || string.IsNullOrWhiteSpace(txtTheloai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            else if (!maDia.IsMatch(txtMadia.Text))
            {
                MessageBox.Show("MADIA phải có dạng Dx với x là các chữ số (tối thiểu 4 chữ số)!");
                return false;
            }
            return true;
        }

        private bool checkMadiaExist(String madia)
        {
            try
            {
                if (conn == null)
                    conn = new SqlConnection(FrmHome.ConnectString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"select * from dia where madia='{madia}'";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        private void reset()
        {
            txtMadia.Text = "";
            txtTendia.Text = "";
            txtTheloai.Text= "";
        }

        private void txtMadia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
