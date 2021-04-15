using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRN292_QLSinhVienDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_QLSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.pRN292_QLSinhVienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'pRN292_QLSinhVienDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.pRN292_QLSinhVienDataSet.Lop);

        }
      
        private void btnView_Click(object sender, EventArgs e)
        {
            string strconn = global::Week9_Class.Properties.Settings.Default.PRN292_QLSinhVienConnectionString;
            string sql = $"select * from sinhvien where malop='{cboMalop.SelectedValue}'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, strconn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
