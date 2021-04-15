
namespace PRN292_Project.view
{
    partial class FrmReportRoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportRoomType));
            this.rpvRoomType = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvRoomType
            // 
            this.rpvRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvRoomType.Location = new System.Drawing.Point(0, 0);
            this.rpvRoomType.Name = "rpvRoomType";
            this.rpvRoomType.ServerReport.BearerToken = null;
            this.rpvRoomType.Size = new System.Drawing.Size(800, 450);
            this.rpvRoomType.TabIndex = 0;
            // 
            // FrmReportRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvRoomType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Room Type";
            this.Load += new System.EventHandler(this.FrmReportRoomType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvRoomType;
    }
}