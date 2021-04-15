
namespace PRN292_Project.view
{
    partial class UcStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tagHistoryLog = new System.Windows.Forms.TabPage();
            this.datetimeFrom = new System.Windows.Forms.DateTimePicker();
            this.datetimeTo = new System.Windows.Forms.DateTimePicker();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.btnViewAllHistoryLog = new System.Windows.Forms.Button();
            this.btnHistorySearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeywordHistory = new System.Windows.Forms.TextBox();
            this.lblHisLogRole = new System.Windows.Forms.Label();
            this.dgvHistoryLogin = new System.Windows.Forms.DataGridView();
            this.colLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogoutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightClickMnTableStaff = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnItemTableStaffDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.txtKeywordStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grStaffInfor = new System.Windows.Forms.GroupBox();
            this.picHidePass = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picShowPass = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUname = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbPassworrd = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabpnStaff = new System.Windows.Forms.TabControl();
            this.tableAdapterManager = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager();
            this.tagHistoryLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLogin)).BeginInit();
            this.rightClickMnTableStaff.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.grStaffInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tabpnStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagHistoryLog
            // 
            this.tagHistoryLog.Controls.Add(this.datetimeFrom);
            this.tagHistoryLog.Controls.Add(this.datetimeTo);
            this.tagHistoryLog.Controls.Add(this.lbDateTo);
            this.tagHistoryLog.Controls.Add(this.lbDateFrom);
            this.tagHistoryLog.Controls.Add(this.btnViewAllHistoryLog);
            this.tagHistoryLog.Controls.Add(this.btnHistorySearch);
            this.tagHistoryLog.Controls.Add(this.label3);
            this.tagHistoryLog.Controls.Add(this.txtKeywordHistory);
            this.tagHistoryLog.Controls.Add(this.lblHisLogRole);
            this.tagHistoryLog.Controls.Add(this.dgvHistoryLogin);
            this.tagHistoryLog.Location = new System.Drawing.Point(4, 25);
            this.tagHistoryLog.Name = "tagHistoryLog";
            this.tagHistoryLog.Padding = new System.Windows.Forms.Padding(3);
            this.tagHistoryLog.Size = new System.Drawing.Size(674, 512);
            this.tagHistoryLog.TabIndex = 1;
            this.tagHistoryLog.Text = "History Login";
            this.tagHistoryLog.UseVisualStyleBackColor = true;
            // 
            // datetimeFrom
            // 
            this.datetimeFrom.CustomFormat = "dd-MM-yyyy HH:mm";
            this.datetimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeFrom.Location = new System.Drawing.Point(114, 71);
            this.datetimeFrom.Name = "datetimeFrom";
            this.datetimeFrom.Size = new System.Drawing.Size(137, 22);
            this.datetimeFrom.TabIndex = 28;
            this.datetimeFrom.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            // 
            // datetimeTo
            // 
            this.datetimeTo.CustomFormat = "dd-MM-yyyy HH:mm";
            this.datetimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeTo.Location = new System.Drawing.Point(340, 72);
            this.datetimeTo.Name = "datetimeTo";
            this.datetimeTo.Size = new System.Drawing.Size(143, 22);
            this.datetimeTo.TabIndex = 27;
            // 
            // lbDateTo
            // 
            this.lbDateTo.AutoSize = true;
            this.lbDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTo.Location = new System.Drawing.Point(303, 77);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(31, 16);
            this.lbDateTo.TabIndex = 24;
            this.lbDateTo.Text = "To :";
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateFrom.Location = new System.Drawing.Point(63, 77);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(45, 16);
            this.lbDateFrom.TabIndex = 22;
            this.lbDateFrom.Text = "From :";
            // 
            // btnViewAllHistoryLog
            // 
            this.btnViewAllHistoryLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnViewAllHistoryLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllHistoryLog.ForeColor = System.Drawing.Color.White;
            this.btnViewAllHistoryLog.Location = new System.Drawing.Point(522, 52);
            this.btnViewAllHistoryLog.Name = "btnViewAllHistoryLog";
            this.btnViewAllHistoryLog.Size = new System.Drawing.Size(75, 28);
            this.btnViewAllHistoryLog.TabIndex = 21;
            this.btnViewAllHistoryLog.Text = "View All";
            this.btnViewAllHistoryLog.UseVisualStyleBackColor = false;
            this.btnViewAllHistoryLog.Click += new System.EventHandler(this.btnViewAllHistoryLog_Click);
            // 
            // btnHistorySearch
            // 
            this.btnHistorySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHistorySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorySearch.ForeColor = System.Drawing.Color.White;
            this.btnHistorySearch.Location = new System.Drawing.Point(522, 18);
            this.btnHistorySearch.Name = "btnHistorySearch";
            this.btnHistorySearch.Size = new System.Drawing.Size(75, 28);
            this.btnHistorySearch.TabIndex = 20;
            this.btnHistorySearch.Text = "Search";
            this.btnHistorySearch.UseVisualStyleBackColor = false;
            this.btnHistorySearch.Click += new System.EventHandler(this.btnHistorySearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Keyword :";
            // 
            // txtKeywordHistory
            // 
            this.txtKeywordHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeywordHistory.Location = new System.Drawing.Point(244, 24);
            this.txtKeywordHistory.Name = "txtKeywordHistory";
            this.txtKeywordHistory.Size = new System.Drawing.Size(175, 22);
            this.txtKeywordHistory.TabIndex = 17;
            // 
            // lblHisLogRole
            // 
            this.lblHisLogRole.AutoSize = true;
            this.lblHisLogRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHisLogRole.Location = new System.Drawing.Point(19, 82);
            this.lblHisLogRole.Name = "lblHisLogRole";
            this.lblHisLogRole.Size = new System.Drawing.Size(0, 16);
            this.lblHisLogRole.TabIndex = 16;
            // 
            // dgvHistoryLogin
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistoryLogin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoryLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogId,
            this.colLogUsername,
            this.colLogFullname,
            this.colLoginTime,
            this.colLogoutTime});
            this.dgvHistoryLogin.ContextMenuStrip = this.rightClickMnTableStaff;
            this.dgvHistoryLogin.Location = new System.Drawing.Point(7, 127);
            this.dgvHistoryLogin.Name = "dgvHistoryLogin";
            this.dgvHistoryLogin.Size = new System.Drawing.Size(661, 377);
            this.dgvHistoryLogin.TabIndex = 15;
            // 
            // colLogId
            // 
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLogId.DefaultCellStyle = dataGridViewCellStyle34;
            this.colLogId.HeaderText = "ID";
            this.colLogId.MinimumWidth = 60;
            this.colLogId.Name = "colLogId";
            this.colLogId.Width = 60;
            // 
            // colLogUsername
            // 
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLogUsername.DefaultCellStyle = dataGridViewCellStyle35;
            this.colLogUsername.HeaderText = "Username";
            this.colLogUsername.MinimumWidth = 100;
            this.colLogUsername.Name = "colLogUsername";
            // 
            // colLogFullname
            // 
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLogFullname.DefaultCellStyle = dataGridViewCellStyle36;
            this.colLogFullname.HeaderText = "Fullname";
            this.colLogFullname.MinimumWidth = 158;
            this.colLogFullname.Name = "colLogFullname";
            this.colLogFullname.Width = 158;
            // 
            // colLoginTime
            // 
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLoginTime.DefaultCellStyle = dataGridViewCellStyle37;
            this.colLoginTime.HeaderText = "Login Time";
            this.colLoginTime.MinimumWidth = 120;
            this.colLoginTime.Name = "colLoginTime";
            this.colLoginTime.Width = 150;
            // 
            // colLogoutTime
            // 
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLogoutTime.DefaultCellStyle = dataGridViewCellStyle38;
            this.colLogoutTime.HeaderText = "Logout Time";
            this.colLogoutTime.MinimumWidth = 120;
            this.colLogoutTime.Name = "colLogoutTime";
            this.colLogoutTime.Width = 150;
            // 
            // rightClickMnTableStaff
            // 
            this.rightClickMnTableStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemTableStaffDeleteRow});
            this.rightClickMnTableStaff.Name = "rightClickMnTableStaff";
            this.rightClickMnTableStaff.Size = new System.Drawing.Size(186, 26);
            // 
            // mnItemTableStaffDeleteRow
            // 
            this.mnItemTableStaffDeleteRow.Name = "mnItemTableStaffDeleteRow";
            this.mnItemTableStaffDeleteRow.Size = new System.Drawing.Size(185, 22);
            this.mnItemTableStaffDeleteRow.Text = "Delete Selected Rows";
            this.mnItemTableStaffDeleteRow.Click += new System.EventHandler(this.mnItemTableStaffDeleteRow_Click);
            // 
            // tabStaff
            // 
            this.tabStaff.AutoScroll = true;
            this.tabStaff.Controls.Add(this.txtKeywordStaff);
            this.tabStaff.Controls.Add(this.label2);
            this.tabStaff.Controls.Add(this.grStaffInfor);
            this.tabStaff.Controls.Add(this.dgvStaff);
            this.tabStaff.Location = new System.Drawing.Point(4, 25);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(674, 512);
            this.tabStaff.TabIndex = 0;
            this.tabStaff.Text = "Staff";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // txtKeywordStaff
            // 
            this.txtKeywordStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeywordStaff.Location = new System.Drawing.Point(93, 230);
            this.txtKeywordStaff.Name = "txtKeywordStaff";
            this.txtKeywordStaff.Size = new System.Drawing.Size(215, 22);
            this.txtKeywordStaff.TabIndex = 14;
            this.txtKeywordStaff.TextChanged += new System.EventHandler(this.txtKeywordStaff_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search :";
            // 
            // grStaffInfor
            // 
            this.grStaffInfor.Controls.Add(this.picHidePass);
            this.grStaffInfor.Controls.Add(this.btnCancel);
            this.grStaffInfor.Controls.Add(this.picShowPass);
            this.grStaffInfor.Controls.Add(this.btnAdd);
            this.grStaffInfor.Controls.Add(this.txtFullname);
            this.grStaffInfor.Controls.Add(this.txtPassword);
            this.grStaffInfor.Controls.Add(this.txtUsername);
            this.grStaffInfor.Controls.Add(this.cbRole);
            this.grStaffInfor.Controls.Add(this.btnUpdate);
            this.grStaffInfor.Controls.Add(this.btnDelete);
            this.grStaffInfor.Controls.Add(this.lblUname);
            this.grStaffInfor.Controls.Add(this.lbRole);
            this.grStaffInfor.Controls.Add(this.lbPassworrd);
            this.grStaffInfor.Controls.Add(this.lbFname);
            this.grStaffInfor.Location = new System.Drawing.Point(175, 6);
            this.grStaffInfor.Name = "grStaffInfor";
            this.grStaffInfor.Size = new System.Drawing.Size(371, 209);
            this.grStaffInfor.TabIndex = 15;
            this.grStaffInfor.TabStop = false;
            // 
            // picHidePass
            // 
            this.picHidePass.Image = global::PRN292_Project.Properties.Resources.icons8_hide_64;
            this.picHidePass.Location = new System.Drawing.Point(312, 56);
            this.picHidePass.Name = "picHidePass";
            this.picHidePass.Size = new System.Drawing.Size(20, 20);
            this.picHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHidePass.TabIndex = 18;
            this.picHidePass.TabStop = false;
            this.picHidePass.Click += new System.EventHandler(this.picHidePass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(44, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picShowPass
            // 
            this.picShowPass.Image = global::PRN292_Project.Properties.Resources.icons8_eye_64;
            this.picShowPass.Location = new System.Drawing.Point(312, 56);
            this.picShowPass.Name = "picShowPass";
            this.picShowPass.Size = new System.Drawing.Size(20, 20);
            this.picShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowPass.TabIndex = 17;
            this.picShowPass.TabStop = false;
            this.picShowPass.Click += new System.EventHandler(this.picShowPass_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(163, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(114, 89);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(220, 22);
            this.txtFullname.TabIndex = 12;
            this.txtFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullname_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(114, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(114, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 22);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Staff",
            "Admin"});
            this.cbRole.Location = new System.Drawing.Point(114, 121);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(220, 24);
            this.cbRole.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(147, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(250, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(10, 24);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(71, 16);
            this.lblUname.TabIndex = 0;
            this.lblUname.Text = "Username";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(41, 124);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(37, 16);
            this.lbRole.TabIndex = 3;
            this.lbRole.Text = "Role";
            // 
            // lbPassworrd
            // 
            this.lbPassworrd.AutoSize = true;
            this.lbPassworrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassworrd.Location = new System.Drawing.Point(13, 58);
            this.lbPassworrd.Name = "lbPassworrd";
            this.lbPassworrd.Size = new System.Drawing.Size(68, 16);
            this.lbPassworrd.TabIndex = 1;
            this.lbPassworrd.Text = "Password";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFname.Location = new System.Drawing.Point(15, 92);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(63, 16);
            this.lbFname.TabIndex = 2;
            this.lbFname.Text = "Fullname";
            // 
            // dgvStaff
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colPassword,
            this.colFullname,
            this.colRole,
            this.colStaffEdit});
            this.dgvStaff.ContextMenuStrip = this.rightClickMnTableStaff;
            this.dgvStaff.Location = new System.Drawing.Point(7, 269);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.Size = new System.Drawing.Size(661, 237);
            this.dgvStaff.TabIndex = 14;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            this.dgvStaff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStaff_CellFormatting);
            // 
            // colUsername
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUsername.DefaultCellStyle = dataGridViewCellStyle39;
            this.colUsername.HeaderText = "Username";
            this.colUsername.MinimumWidth = 100;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 120;
            // 
            // colPassword
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPassword.DefaultCellStyle = dataGridViewCellStyle40;
            this.colPassword.HeaderText = "Password";
            this.colPassword.MinimumWidth = 100;
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 140;
            // 
            // colFullname
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colFullname.DefaultCellStyle = dataGridViewCellStyle41;
            this.colFullname.HeaderText = "Fullname";
            this.colFullname.MinimumWidth = 150;
            this.colFullname.Name = "colFullname";
            this.colFullname.ReadOnly = true;
            this.colFullname.Width = 200;
            // 
            // colRole
            // 
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRole.DefaultCellStyle = dataGridViewCellStyle42;
            this.colRole.HeaderText = "Role";
            this.colRole.MinimumWidth = 100;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            // 
            // colStaffEdit
            // 
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            this.colStaffEdit.DefaultCellStyle = dataGridViewCellStyle43;
            this.colStaffEdit.HeaderText = "Edit";
            this.colStaffEdit.Name = "colStaffEdit";
            this.colStaffEdit.ReadOnly = true;
            this.colStaffEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStaffEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStaffEdit.Width = 58;
            // 
            // tabpnStaff
            // 
            this.tabpnStaff.Controls.Add(this.tabStaff);
            this.tabpnStaff.Controls.Add(this.tagHistoryLog);
            this.tabpnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpnStaff.Location = new System.Drawing.Point(3, 3);
            this.tabpnStaff.Name = "tabpnStaff";
            this.tabpnStaff.SelectedIndex = 0;
            this.tabpnStaff.Size = new System.Drawing.Size(682, 541);
            this.tabpnStaff.TabIndex = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckinTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.HistoryLogTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UcStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabpnStaff);
            this.Name = "UcStaff";
            this.Size = new System.Drawing.Size(688, 547);
            this.Load += new System.EventHandler(this.UcStaff_Load);
            this.tagHistoryLog.ResumeLayout(false);
            this.tagHistoryLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLogin)).EndInit();
            this.rightClickMnTableStaff.ResumeLayout(false);
            this.tabStaff.ResumeLayout(false);
            this.tabStaff.PerformLayout();
            this.grStaffInfor.ResumeLayout(false);
            this.grStaffInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tabpnStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tagHistoryLog;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbPassworrd;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.TabControl tabpnStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridView dgvHistoryLogin;
        private System.Windows.Forms.Button btnHistorySearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeywordHistory;
        private System.Windows.Forms.Label lblHisLogRole;
        private System.Windows.Forms.Button btnViewAllHistoryLog;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.GroupBox grStaffInfor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtKeywordStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewButtonColumn colStaffEdit;
        private System.Windows.Forms.ContextMenuStrip rightClickMnTableStaff;
        private System.Windows.Forms.ToolStripMenuItem mnItemTableStaffDeleteRow;
        private System.Windows.Forms.PictureBox picHidePass;
        private System.Windows.Forms.PictureBox picShowPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogoutTime;
        private System.Windows.Forms.DateTimePicker datetimeFrom;
        private System.Windows.Forms.DateTimePicker datetimeTo;
        private PRN292_HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
