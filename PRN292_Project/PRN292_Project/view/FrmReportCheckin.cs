using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRN292_Project.view
{
    public partial class FrmReportCheckin : Form
    {
        public FrmReportCheckin()
        {
            InitializeComponent();
        }

        private void FrmReportCheckin_Load(object sender, EventArgs e)
        {
            this.rpvCheckin.RefreshReport();
            View();
        }

        private void View()
        {
            string sql = "SELECT * from Checkin;";
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSetCheckin", dt);
                this.rpvCheckin.LocalReport.ReportPath = @"..\..\view\Report\rpCheckin.rdlc";
                rpvCheckin.LocalReport.DataSources.Clear();
                rpvCheckin.LocalReport.DataSources.Add(rds);
                rpvCheckin.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
