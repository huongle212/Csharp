using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class FrmReportStaff : Form
    {
        public FrmReportStaff()
        {
            InitializeComponent();
        }

        private void FrmReportStaff_Load(object sender, EventArgs e)
        {

            this.rpvStaff.RefreshReport();
            View();
        }

        private void View()
        {
            string sql = "SELECT * from Staff;";
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSetStaff", dt);
                this.rpvStaff.LocalReport.ReportPath = @"..\..\view\Report\rpStaff.rdlc";
                rpvStaff.LocalReport.DataSources.Clear();
                rpvStaff.LocalReport.DataSources.Add(rds);
                rpvStaff.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
