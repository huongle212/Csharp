
namespace PRN292_Project.view
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.guestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.guestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuNhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatuLblSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.pnLeft.Controls.Add(this.btnStaff);
            this.pnLeft.Controls.Add(this.btnRoom);
            this.pnLeft.Controls.Add(this.btnGuest);
            this.pnLeft.Controls.Add(this.btnCheckout);
            this.pnLeft.Controls.Add(this.btnCheckin);
            this.pnLeft.Controls.Add(this.label1);
            this.pnLeft.Controls.Add(this.pictureBox1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(223, 594);
            this.pnLeft.TabIndex = 1;
            // 
            // btnStaff
            // 
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::PRN292_Project.Properties.Resources.staff1;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 397);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(223, 40);
            this.btnStaff.TabIndex = 13;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = global::PRN292_Project.Properties.Resources.bedroom2;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(0, 341);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRoom.Size = new System.Drawing.Size(223, 40);
            this.btnRoom.TabIndex = 10;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.ForeColor = System.Drawing.Color.White;
            this.btnGuest.Image = ((System.Drawing.Image)(resources.GetObject("btnGuest.Image")));
            this.btnGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuest.Location = new System.Drawing.Point(0, 288);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGuest.Size = new System.Drawing.Size(223, 40);
            this.btnGuest.TabIndex = 9;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::PRN292_Project.Properties.Resources._out;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(0, 236);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCheckout.Size = new System.Drawing.Size(223, 40);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.Color.White;
            this.btnCheckin.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckin.Image")));
            this.btnCheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckin.Location = new System.Drawing.Point(0, 184);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCheckin.Size = new System.Drawing.Size(223, 40);
            this.btnCheckin.TabIndex = 7;
            this.btnCheckin.Text = "Check In";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(129)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(49, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Royal Hotel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRN292_Project.Properties.Resources.hotel_logo;
            this.pictureBox1.Location = new System.Drawing.Point(56, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.menuStrip);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(223, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(688, 24);
            this.pnTop.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.thuNhoToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(688, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "&Home";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomToolStripMenuItem1,
            this.toolStripSeparator1,
            this.checkinToolStripMenuItem1,
            this.checkoutToolStripMenuItem1,
            this.toolStripSeparator2,
            this.guestToolStripMenuItem1,
            this.staffToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // roomToolStripMenuItem1
            // 
            this.roomToolStripMenuItem1.Name = "roomToolStripMenuItem1";
            this.roomToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.roomToolStripMenuItem1.Text = "Room";
            this.roomToolStripMenuItem1.Click += new System.EventHandler(this.roomToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // checkinToolStripMenuItem1
            // 
            this.checkinToolStripMenuItem1.Name = "checkinToolStripMenuItem1";
            this.checkinToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.checkinToolStripMenuItem1.Text = "Checkin";
            this.checkinToolStripMenuItem1.Click += new System.EventHandler(this.checkinToolStripMenuItem1_Click);
            // 
            // checkoutToolStripMenuItem1
            // 
            this.checkoutToolStripMenuItem1.Name = "checkoutToolStripMenuItem1";
            this.checkoutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.checkoutToolStripMenuItem1.Text = "Checkout";
            this.checkoutToolStripMenuItem1.Click += new System.EventHandler(this.checkoutToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // guestToolStripMenuItem1
            // 
            this.guestToolStripMenuItem1.Name = "guestToolStripMenuItem1";
            this.guestToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.guestToolStripMenuItem1.Text = "Guest";
            this.guestToolStripMenuItem1.Click += new System.EventHandler(this.guestToolStripMenuItem1_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listStaffsToolStripMenuItem,
            this.historyLogToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // listStaffsToolStripMenuItem
            // 
            this.listStaffsToolStripMenuItem.Name = "listStaffsToolStripMenuItem";
            this.listStaffsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listStaffsToolStripMenuItem.Text = "List Staffs";
            this.listStaffsToolStripMenuItem.Click += new System.EventHandler(this.listStaffsToolStripMenuItem_Click);
            // 
            // historyLogToolStripMenuItem
            // 
            this.historyLogToolStripMenuItem.Name = "historyLogToolStripMenuItem";
            this.historyLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historyLogToolStripMenuItem.Text = "History Log";
            this.historyLogToolStripMenuItem.Click += new System.EventHandler(this.historyLogToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomToolStripMenuItem,
            this.roomTypeToolStripMenuItem1,
            this.toolStripSeparator3,
            this.checkInToolStripMenuItem,
            this.toolStripSeparator4,
            this.guestToolStripMenuItem,
            this.staffToolStripMenuItem1});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // roomTypeToolStripMenuItem1
            // 
            this.roomTypeToolStripMenuItem1.Name = "roomTypeToolStripMenuItem1";
            this.roomTypeToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.roomTypeToolStripMenuItem1.Text = "Room Type";
            this.roomTypeToolStripMenuItem1.Click += new System.EventHandler(this.roomTypeToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(130, 6);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.checkInToolStripMenuItem.Text = "Check in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(130, 6);
            // 
            // guestToolStripMenuItem
            // 
            this.guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            this.guestToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.guestToolStripMenuItem.Text = "Guest";
            this.guestToolStripMenuItem.Click += new System.EventHandler(this.guestToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem1
            // 
            this.staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            this.staffToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.staffToolStripMenuItem1.Text = "Staff";
            this.staffToolStripMenuItem1.Click += new System.EventHandler(this.staffToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.closeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // thuNhoToolStripMenuItem
            // 
            this.thuNhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thuNhoToolStripMenuItem.Image")));
            this.thuNhoToolStripMenuItem.Name = "thuNhoToolStripMenuItem";
            this.thuNhoToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.thuNhoToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.profileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.profileToolStripMenuItem.Text = "Username";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Log&out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.White;
            this.pnBottom.Controls.Add(this.statusStrip);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(223, 571);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(688, 23);
            this.pnBottom.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripStatuLblSpace,
            this.toolStripStatusLblDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 1);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(688, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatus.Text = "Ready";
            // 
            // toolStripStatuLblSpace
            // 
            this.toolStripStatuLblSpace.Name = "toolStripStatuLblSpace";
            this.toolStripStatuLblSpace.Size = new System.Drawing.Size(598, 17);
            this.toolStripStatuLblSpace.Spring = true;
            this.toolStripStatuLblSpace.Text = " ";
            // 
            // toolStripStatusLblDate
            // 
            this.toolStripStatusLblDate.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.toolStripStatusLblDate.Name = "toolStripStatusLblDate";
            this.toolStripStatusLblDate.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLblDate.Text = "Date";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnCenter
            // 
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(223, 24);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(688, 547);
            this.pnCenter.TabIndex = 4;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 594);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuNhoToolStripMenuItem;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuLblSpace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem guestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roomTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStaffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem1;
    }
}