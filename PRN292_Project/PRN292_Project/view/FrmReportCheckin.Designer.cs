
namespace PRN292_Project.view
{
    partial class FrmReportCheckin
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
            this.rpvCheckin = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvCheckin
            // 
            this.rpvCheckin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvCheckin.Location = new System.Drawing.Point(0, 0);
            this.rpvCheckin.Name = "rpvCheckin";
            this.rpvCheckin.ServerReport.BearerToken = null;
            this.rpvCheckin.Size = new System.Drawing.Size(930, 519);
            this.rpvCheckin.TabIndex = 0;
            // 
            // FrmReportCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 519);
            this.Controls.Add(this.rpvCheckin);
            this.Name = "FrmReportCheckin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Checkin";
            this.Load += new System.EventHandler(this.FrmReportCheckin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCheckin;
    }
}