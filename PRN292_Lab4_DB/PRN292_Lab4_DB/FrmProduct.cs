using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Lab4_DB
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string sql = $"select * from Products where ProductName like N'%{txtName.Text}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,FrmMain.Strconn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void ViewAll()
        {
            string strconn = global::PRN292_Lab4_DB.Properties.Settings.Default.NorthwindConnectionString;
            string sql = "select * from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,FrmMain.Strconn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
