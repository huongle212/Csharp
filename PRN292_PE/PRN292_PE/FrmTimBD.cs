using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_PE
{
    public partial class FrmTimBD : Form
    {

        SqlConnection conn = null;
        public FrmTimBD()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string tukhoa = txtSearch.Text;
                string sql = $"SELECT * from DIA where Tendia like N'%{tukhoa}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, FrmHome.ConnectString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dgvDia.DataSource = dataSet.Tables[0];
                setCDTableHeader(dgvDia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void setCDTableHeader(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "Mã đĩa";
            dataGridView.Columns[1].HeaderText = "Tên đĩa";
            dataGridView.Columns[2].HeaderText = "Thể loại";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvDia.SelectedRows;
            if (selectedRows.Count == 0) return;
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                return;
            String diadelete = "('";
            foreach (DataGridViewRow row in selectedRows)
            {
                diadelete += row.Cells[0].Value + "','";
            }
            diadelete = diadelete.Substring(0, diadelete.Length - 2) + ")";
            try
            {
                if (conn == null) conn = new SqlConnection(FrmHome.ConnectString);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand($"Delete from Dia where madia in {diadelete}", conn);
                int result = command.ExecuteNonQuery();
                conn.Close();
                if (result > 0)
                {
                    txtSearch.Text = "";
                    btnSearch_Click(null, null);
                }
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!\nLỗi: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
