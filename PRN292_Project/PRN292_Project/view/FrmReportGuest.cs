using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class FrmReportGuest : Form
    {
        public FrmReportGuest()
        {
            InitializeComponent();
        }

        private void FrmReportGuest_Load(object sender, EventArgs e)
        {
            this.rpvGuest.RefreshReport();
            View();
        }

        private void View()
        {
            string sql = "SELECT * from Guest;";
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSetGuest", dt);
                this.rpvGuest.LocalReport.ReportPath = @"..\..\view\Report\rpGuest.rdlc";
                rpvGuest.LocalReport.DataSources.Clear();
                rpvGuest.LocalReport.DataSources.Add(rds);
                rpvGuest.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
