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
    public partial class FrmReportRoom : Form
    {
        public FrmReportRoom()
        {
            InitializeComponent();
        }

        private void FrmReportRoom_Load(object sender, EventArgs e)
        {
            this.reportRoom.RefreshReport();
            ViewAllRoom();
        }

        private void ViewAllRoom()
        {
            //Khai báo câu lệnh SQL
            string sql = "Select roomNo, RoomType.[name] as [type], isVacant " +
                "From Room Inner Join RoomType ON RoomType.roomTypeId = Room.[type];";
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, FrmHome.Strconn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource("DataSetRoom", dt);
                //Đường dẫn báo cáo
                this.reportRoom.LocalReport.ReportPath = @"..\..\view\Report\rpRoom.rdlc";
                 //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportRoom.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportRoom.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportRoom.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
