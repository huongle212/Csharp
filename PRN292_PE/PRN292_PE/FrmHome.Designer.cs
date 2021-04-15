
namespace PRN292_PE
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.readyStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.welcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timkiemTheoTenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capnhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.timkiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnHome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHƯƠNG TRÌNH";
            // 
            // datetimeStatus
            // 
            this.datetimeStatus.Name = "datetimeStatus";
            this.datetimeStatus.Size = new System.Drawing.Size(57, 17);
            this.datetimeStatus.Text = "DateTime";
            this.datetimeStatus.Click += new System.EventHandler(this.datetimeStatus_Click);
            // 
            // spaceStatus
            // 
            this.spaceStatus.Name = "spaceStatus";
            this.spaceStatus.Size = new System.Drawing.Size(625, 17);
            this.spaceStatus.Spring = true;
            // 
            // readyStatus
            // 
            this.readyStatus.Name = "readyStatus";
            this.readyStatus.Size = new System.Drawing.Size(39, 17);
            this.readyStatus.Text = "Ready";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readyStatus,
            this.spaceStatus,
            this.datetimeStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 399);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(736, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // welcomeToolStripMenuItem
            // 
            this.welcomeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.welcomeToolStripMenuItem.Name = "welcomeToolStripMenuItem";
            this.welcomeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.welcomeToolStripMenuItem.Text = "Welcome";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeToolStripMenuItem.Image = global::PRN292_PE.Properties.Resources.minimize;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripMenuItem.Image = global::PRN292_PE.Properties.Resources.close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // huongDanToolStripMenuItem
            // 
            this.huongDanToolStripMenuItem.Name = "huongDanToolStripMenuItem";
            this.huongDanToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.huongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // thongkeToolStripMenuItem
            // 
            this.thongkeToolStripMenuItem.Name = "thongkeToolStripMenuItem";
            this.thongkeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thongkeToolStripMenuItem.Text = "Thống kê";
            // 
            // timkiemTheoTenToolStripMenuItem
            // 
            this.timkiemTheoTenToolStripMenuItem.Name = "timkiemTheoTenToolStripMenuItem";
            this.timkiemTheoTenToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.timkiemTheoTenToolStripMenuItem.Text = "Tên băng đĩa";
            this.timkiemTheoTenToolStripMenuItem.Click += new System.EventHandler(this.timkiemTheoTenToolStripMenuItem_Click);
            // 
            // capnhatToolStripMenuItem
            // 
            this.capnhatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.capnhatToolStripMenuItem.Name = "capnhatToolStripMenuItem";
            this.capnhatToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.capnhatToolStripMenuItem.Text = "Cập nhật";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editToolStripMenuItem.Text = "Băng đĩa";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hethongToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.capnhatToolStripMenuItem,
            this.timkiemToolStripMenuItem,
            this.thongkeToolStripMenuItem,
            this.huongDanToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.welcomeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(736, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // timkiemToolStripMenuItem
            // 
            this.timkiemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timkiemTheoTenToolStripMenuItem});
            this.timkiemToolStripMenuItem.Name = "timkiemToolStripMenuItem";
            this.timkiemToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.timkiemToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // pnHome
            // 
            this.pnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnHome.BackgroundImage")));
            this.pnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHome.Controls.Add(this.label3);
            this.pnHome.Controls.Add(this.label1);
            this.pnHome.Controls.Add(this.label2);
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(736, 421);
            this.pnHome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "CHO THUÊ BĂNG ĐĨA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRN292_PE.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(736, 421);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnHome);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cho thuê băng đĩa";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel datetimeStatus;
        private System.Windows.Forms.ToolStripStatusLabel spaceStatus;
        private System.Windows.Forms.ToolStripStatusLabel readyStatus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem welcomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timkiemTheoTenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capnhatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem timkiemToolStripMenuItem;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

