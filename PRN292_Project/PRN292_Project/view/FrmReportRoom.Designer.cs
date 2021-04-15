
namespace PRN292_Project.view
{
    partial class FrmReportRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportRoom));
            this.reportRoom = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportRoom
            // 
            this.reportRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportRoom.Location = new System.Drawing.Point(0, 0);
            this.reportRoom.Name = "reportRoom";
            this.reportRoom.ServerReport.BearerToken = null;
            this.reportRoom.Size = new System.Drawing.Size(755, 517);
            this.reportRoom.TabIndex = 0;
            // 
            // FrmReportRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 517);
            this.Controls.Add(this.reportRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Room";
            this.Load += new System.EventHandler(this.FrmReportRoom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportRoom;
    }
}