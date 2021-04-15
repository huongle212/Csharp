using Microsoft.Reporting.WinForms;
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

namespace PRN292_Project.view
{
    public partial class FrmReportRoomType : Form
    {
        public FrmReportRoomType()
        {
            InitializeComponent();
        }

        private void FrmReportRoomType_Load(object sender, EventArgs e)
        {
            this.rpvRoomType.RefreshReport();
            View();
        }

        private void View()
        {
            string sql = "SELECT roomTypeId as [roomTypeId],[name],roomRate,noOfOccupancy, COUNT(roomNo) as totalRoom,[description]" +
                    "FROM RoomType as rt Left join Room on rt.roomTypeId = Room.[type]" +
                    "GROUP BY roomTypeId, [name],[description], roomRate,noOfOccupancy;";
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                ReportDataSource rds = new ReportDataSource("DataSetRoomType", dt);
                this.rpvRoomType.LocalReport.ReportPath = @"..\..\view\Report\rpRoomType.rdlc";
                rpvRoomType.LocalReport.DataSources.Clear();
                rpvRoomType.LocalReport.DataSources.Add(rds);
                rpvRoomType.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
