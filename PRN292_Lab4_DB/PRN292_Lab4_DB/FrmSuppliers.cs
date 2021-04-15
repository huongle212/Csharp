using System;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Lab4_DB
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
        }

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string sql = $"select * from Suppliers where CompanyName like N'%{txtName.Text}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,FrmMain.Strconn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void ViewAll()
        {
            
            string sql = $"select * from Suppliers";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,FrmMain.Strconn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
