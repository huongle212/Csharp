
namespace PRN292_Project.view
{
    partial class UcCheckin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCheckin));
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRN292_HotelDBDataSet = new PRN292_Project.PRN292_HotelDBDataSet();
            this.roomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkroomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.RoomTableAdapter();
            this.tableAdapterManager = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager();
            this.roomTypeTableAdapter = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.RoomTypeTableAdapter();
            this.guestTableAdapter = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.GuestTableAdapter();
            this.tabListRoom = new System.Windows.Forms.TabPage();
            this.cbLRAllRoomType = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.cbxVacant = new System.Windows.Forms.ComboBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.txtSearchRoomNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabCheckout = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCOGuestName = new System.Windows.Forms.TextBox();
            this.viewCheckinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpCOCheckoutTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCORoomType = new System.Windows.Forms.TextBox();
            this.txtCOAdult = new System.Windows.Forms.TextBox();
            this.txtCOChild = new System.Windows.Forms.TextBox();
            this.txtCORoomRate = new System.Windows.Forms.TextBox();
            this.txtCOTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCODays = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxCORoomNo = new System.Windows.Forms.ComboBox();
            this.dtpCOCheckinTime = new System.Windows.Forms.DateTimePicker();
            this.dtpCOExpectCheckoutTime = new System.Windows.Forms.DateTimePicker();
            this.txtCOIdentityNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCOReset = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.tabCheckin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCIIdentityNo = new System.Windows.Forms.TextBox();
            this.cbxCIGuestID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCiSearchRoom = new System.Windows.Forms.Button();
            this.txtCIRoomRate = new System.Windows.Forms.TextBox();
            this.txtCINoOccupancy = new System.Windows.Forms.TextBox();
            this.txtCISubTotal = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtCIDays = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCIRoomNo = new System.Windows.Forms.ComboBox();
            this.cbxCIRoomType = new System.Windows.Forms.ComboBox();
            this.dtpCICheckInTime = new System.Windows.Forms.DateTimePicker();
            this.cbxCIGuestName = new System.Windows.Forms.ComboBox();
            this.ciNoChild = new System.Windows.Forms.NumericUpDown();
            this.ciNoAdult = new System.Windows.Forms.NumericUpDown();
            this.dtpCICheckoutTime = new System.Windows.Forms.DateTimePicker();
            this.txtCIPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGuestName = new System.Windows.Forms.Label();
            this.tabControlCICO = new System.Windows.Forms.TabControl();
            this.viewCheckinTableAdapter = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.ViewCheckinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_HotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkroomTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.tabListRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabCheckout.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckinBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabCheckin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciNoChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciNoAdult)).BeginInit();
            this.tabControlCICO.SuspendLayout();
            this.SuspendLayout();
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.pRN292_HotelDBDataSet;
            // 
            // pRN292_HotelDBDataSet
            // 
            this.pRN292_HotelDBDataSet.DataSetName = "PRN292_HotelDBDataSet";
            this.pRN292_HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTypeBindingSource
            // 
            this.roomTypeBindingSource.DataMember = "RoomType";
            this.roomTypeBindingSource.DataSource = this.pRN292_HotelDBDataSet;
            // 
            // fkroomTypeBindingSource
            // 
            this.fkroomTypeBindingSource.DataMember = "fk_roomType";
            this.fkroomTypeBindingSource.DataSource = this.roomTypeBindingSource;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.pRN292_HotelDBDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckinTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.HistoryLogTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager.RoomTypeTableAdapter = this.roomTypeTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomTypeTableAdapter
            // 
            this.roomTypeTableAdapter.ClearBeforeFill = true;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // tabListRoom
            // 
            this.tabListRoom.Controls.Add(this.cbLRAllRoomType);
            this.tabListRoom.Controls.Add(this.label31);
            this.tabListRoom.Controls.Add(this.label29);
            this.tabListRoom.Controls.Add(this.cbxRoomType);
            this.tabListRoom.Controls.Add(this.cbxVacant);
            this.tabListRoom.Controls.Add(this.dgvRoom);
            this.tabListRoom.Controls.Add(this.txtSearchRoomNo);
            this.tabListRoom.Controls.Add(this.label18);
            this.tabListRoom.Location = new System.Drawing.Point(4, 22);
            this.tabListRoom.Name = "tabListRoom";
            this.tabListRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabListRoom.Size = new System.Drawing.Size(680, 505);
            this.tabListRoom.TabIndex = 3;
            this.tabListRoom.Text = "List Room";
            this.tabListRoom.UseVisualStyleBackColor = true;
            // 
            // cbLRAllRoomType
            // 
            this.cbLRAllRoomType.AutoSize = true;
            this.cbLRAllRoomType.Location = new System.Drawing.Point(29, 194);
            this.cbLRAllRoomType.Name = "cbLRAllRoomType";
            this.cbLRAllRoomType.Size = new System.Drawing.Size(95, 17);
            this.cbLRAllRoomType.TabIndex = 34;
            this.cbLRAllRoomType.Text = "All Room Type";
            this.cbLRAllRoomType.UseVisualStyleBackColor = true;
            this.cbLRAllRoomType.CheckedChanged += new System.EventHandler(this.cbLRAllRoomType_CheckedChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(2, 142);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 16);
            this.label31.TabIndex = 32;
            this.label31.Text = "Room Type:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label29.Location = new System.Drawing.Point(267, 19);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(145, 37);
            this.label29.TabIndex = 31;
            this.label29.Text = "List Room";
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.BackColor = System.Drawing.Color.White;
            this.cbxRoomType.DataSource = this.roomTypeBindingSource;
            this.cbxRoomType.DisplayMember = "name";
            this.cbxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(25, 165);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(141, 21);
            this.cbxRoomType.TabIndex = 30;
            this.cbxRoomType.ValueMember = "roomTypeId";
            this.cbxRoomType.SelectedIndexChanged += new System.EventHandler(this.cbxRoomType_SelectedIndexChanged);
            // 
            // cbxVacant
            // 
            this.cbxVacant.BackColor = System.Drawing.Color.White;
            this.cbxVacant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVacant.FormattingEnabled = true;
            this.cbxVacant.Items.AddRange(new object[] {
            "Occupied",
            "Vacant",
            "All"});
            this.cbxVacant.Location = new System.Drawing.Point(29, 222);
            this.cbxVacant.Name = "cbxVacant";
            this.cbxVacant.Size = new System.Drawing.Size(90, 21);
            this.cbxVacant.TabIndex = 29;
            this.cbxVacant.SelectedIndexChanged += new System.EventHandler(this.cbxVacant_SelectedIndexChanged);
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(180, 85);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(477, 415);
            this.dgvRoom.TabIndex = 28;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // txtSearchRoomNo
            // 
            this.txtSearchRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoomNo.Location = new System.Drawing.Point(29, 112);
            this.txtSearchRoomNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRoomNo.Name = "txtSearchRoomNo";
            this.txtSearchRoomNo.Size = new System.Drawing.Size(137, 22);
            this.txtSearchRoomNo.TabIndex = 27;
            this.txtSearchRoomNo.TextChanged += new System.EventHandler(this.txtSearchRoomNo_TextChanged);
            this.txtSearchRoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchRoomNo_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 83);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 26;
            this.label18.Text = "RoomNo:";
            // 
            // tabCheckout
            // 
            this.tabCheckout.Controls.Add(this.panel4);
            this.tabCheckout.Controls.Add(this.panel3);
            this.tabCheckout.Controls.Add(this.label27);
            this.tabCheckout.Location = new System.Drawing.Point(4, 22);
            this.tabCheckout.Name = "tabCheckout";
            this.tabCheckout.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckout.Size = new System.Drawing.Size(680, 505);
            this.tabCheckout.TabIndex = 1;
            this.tabCheckout.Text = "Check Out";
            this.tabCheckout.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtCOGuestName);
            this.panel4.Controls.Add(this.dtpCOCheckoutTime);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtCORoomType);
            this.panel4.Controls.Add(this.txtCOAdult);
            this.panel4.Controls.Add(this.txtCOChild);
            this.panel4.Controls.Add(this.txtCORoomRate);
            this.panel4.Controls.Add(this.txtCOTotal);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txtCODays);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.cbxCORoomNo);
            this.panel4.Controls.Add(this.dtpCOCheckinTime);
            this.panel4.Controls.Add(this.dtpCOExpectCheckoutTime);
            this.panel4.Controls.Add(this.txtCOIdentityNo);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Location = new System.Drawing.Point(1, 63);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(678, 323);
            this.panel4.TabIndex = 33;
            // 
            // txtCOGuestName
            // 
            this.txtCOGuestName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewCheckinBindingSource, "fullname", true));
            this.txtCOGuestName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.viewCheckinBindingSource, "fullname", true));
            this.txtCOGuestName.Location = new System.Drawing.Point(133, 17);
            this.txtCOGuestName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCOGuestName.Name = "txtCOGuestName";
            this.txtCOGuestName.ReadOnly = true;
            this.txtCOGuestName.Size = new System.Drawing.Size(171, 20);
            this.txtCOGuestName.TabIndex = 50;
            // 
            // viewCheckinBindingSource
            // 
            this.viewCheckinBindingSource.DataMember = "ViewCheckin";
            this.viewCheckinBindingSource.DataSource = this.pRN292_HotelDBDataSet;
            // 
            // dtpCOCheckoutTime
            // 
            this.dtpCOCheckoutTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpCOCheckoutTime.Enabled = false;
            this.dtpCOCheckoutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCOCheckoutTime.Location = new System.Drawing.Point(133, 140);
            this.dtpCOCheckoutTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCOCheckoutTime.Name = "dtpCOCheckoutTime";
            this.dtpCOCheckoutTime.Size = new System.Drawing.Size(171, 20);
            this.dtpCOCheckoutTime.TabIndex = 49;
            this.dtpCOCheckoutTime.ValueChanged += new System.EventHandler(this.dtpCOCheckoutTime_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label13.Location = new System.Drawing.Point(24, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Check out time: ";
            // 
            // txtCORoomType
            // 
            this.txtCORoomType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewCheckinBindingSource, "name", true));
            this.txtCORoomType.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.viewCheckinBindingSource, "name", true));
            this.txtCORoomType.Location = new System.Drawing.Point(439, 56);
            this.txtCORoomType.Margin = new System.Windows.Forms.Padding(2);
            this.txtCORoomType.Name = "txtCORoomType";
            this.txtCORoomType.ReadOnly = true;
            this.txtCORoomType.Size = new System.Drawing.Size(171, 20);
            this.txtCORoomType.TabIndex = 47;
            // 
            // txtCOAdult
            // 
            this.txtCOAdult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewCheckinBindingSource, "adult", true));
            this.txtCOAdult.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.viewCheckinBindingSource, "adult", true));
            this.txtCOAdult.Location = new System.Drawing.Point(308, 196);
            this.txtCOAdult.Margin = new System.Windows.Forms.Padding(2);
            this.txtCOAdult.Name = "txtCOAdult";
            this.txtCOAdult.ReadOnly = true;
            this.txtCOAdult.Size = new System.Drawing.Size(48, 20);
            this.txtCOAdult.TabIndex = 46;
            // 
            // txtCOChild
            // 
            this.txtCOChild.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewCheckinBindingSource, "child", true));
            this.txtCOChild.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.viewCheckinBindingSource, "child", true));
            this.txtCOChild.Location = new System.Drawing.Point(130, 200);
            this.txtCOChild.Margin = new System.Windows.Forms.Padding(2);
            this.txtCOChild.Name = "txtCOChild";
            this.txtCOChild.ReadOnly = true;
            this.txtCOChild.Size = new System.Drawing.Size(48, 20);
            this.txtCOChild.TabIndex = 45;
            // 
            // txtCORoomRate
            // 
            this.txtCORoomRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewCheckinBindingSource, "roomRate", true));
            this.txtCORoomRate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.viewCheckinBindingSource, "roomRate", true));
            this.txtCORoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCORoomRate.Location = new System.Drawing.Point(439, 90);
            this.txtCORoomRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCORoomRate.Name = "txtCORoomRate";
            this.txtCORoomRate.ReadOnly = true;
            this.txtCORoomRate.Size = new System.Drawing.Size(129, 21);
            this.txtCORoomRate.TabIndex = 44;
            this.txtCORoomRate.Text = "0 VND";
            this.txtCORoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCORoomRate.TextChanged += new System.EventHandler(this.txtCORoomRate_TextChanged);
            // 
            // txtCOTotal
            // 
            this.txtCOTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOTotal.Location = new System.Drawing.Point(498, 288);
            this.txtCOTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCOTotal.Name = "txtCOTotal";
            this.txtCOTotal.ReadOnly = true;
            this.txtCOTotal.Size = new System.Drawing.Size(149, 21);
            this.txtCOTotal.TabIndex = 41;
            this.txtCOTotal.Text = "0 VND";
            this.txtCOTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label15.Location = new System.Drawing.Point(436, 290);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Total:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCODays
            // 
            this.txtCODays.Location = new System.Drawing.Point(498, 200);
            this.txtCODays.Margin = new System.Windows.Forms.Padding(2);
            this.txtCODays.Name = "txtCODays";
            this.txtCODays.ReadOnly = true;
            this.txtCODays.Size = new System.Drawing.Size(48, 20);
            this.txtCODays.TabIndex = 33;
            this.txtCODays.TextChanged += new System.EventHandler(this.txtCODays_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label17.Location = new System.Drawing.Point(407, 200);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "No. of Days:";
            // 
            // cbxCORoomNo
            // 
            this.cbxCORoomNo.DataSource = this.viewCheckinBindingSource;
            this.cbxCORoomNo.DisplayMember = "roomNo";
            this.cbxCORoomNo.FormattingEnabled = true;
            this.cbxCORoomNo.Location = new System.Drawing.Point(439, 13);
            this.cbxCORoomNo.Name = "cbxCORoomNo";
            this.cbxCORoomNo.Size = new System.Drawing.Size(127, 21);
            this.cbxCORoomNo.TabIndex = 29;
            this.cbxCORoomNo.ValueMember = "id";
            this.cbxCORoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCORoomNo_KeyPress);
            // 
            // dtpCOCheckinTime
            // 
            this.dtpCOCheckinTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpCOCheckinTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viewCheckinBindingSource, "checkinTime", true));
            this.dtpCOCheckinTime.Enabled = false;
            this.dtpCOCheckinTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCOCheckinTime.Location = new System.Drawing.Point(133, 91);
            this.dtpCOCheckinTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCOCheckinTime.Name = "dtpCOCheckinTime";
            this.dtpCOCheckinTime.Size = new System.Drawing.Size(171, 20);
            this.dtpCOCheckinTime.TabIndex = 27;
            this.dtpCOCheckinTime.ValueChanged += new System.EventHandler(this.dtpCOCheckinTime_ValueChanged);
            // 
            // dtpCOExpectCheckoutTime
            // 
            this.dtpCOExpectCheckoutTime.CustomFormat = "yyyy-MM-dd";
            this.dtpCOExpectCheckoutTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.viewCheckinBindingSource, "expectedCheckoutTime", true));
            this.dtpCOExpectCheckoutTime.Enabled = false;
            this.dtpCOExpectCheckoutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCOExpectCheckoutTime.Location = new System.Drawing.Point(476, 138);
            this.dtpCOExpectCheckoutTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCOExpectCheckoutTime.Name = "dtpCOExpectCheckoutTime";
            this.dtpCOExpectCheckoutTime.Size = new System.Drawing.Size(129, 20);
            this.dtpCOExpectCheckoutTime.TabIndex = 18;
            // 
            // txtCOIdentityNo
            // 
            this.txtCOIdentityNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewCheckinBindingSource, "identityNumber", true));
            this.txtCOIdentityNo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.viewCheckinBindingSource, "identityNumber", true));
            this.txtCOIdentityNo.Location = new System.Drawing.Point(133, 56);
            this.txtCOIdentityNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCOIdentityNo.Name = "txtCOIdentityNo";
            this.txtCOIdentityNo.ReadOnly = true;
            this.txtCOIdentityNo.Size = new System.Drawing.Size(171, 20);
            this.txtCOIdentityNo.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label19.Location = new System.Drawing.Point(351, 92);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 17);
            this.label19.TabIndex = 13;
            this.label19.Text = "Room Rate:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label20.Location = new System.Drawing.Point(28, 200);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 17);
            this.label20.TabIndex = 9;
            this.label20.Text = "No. of Child:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label21.Location = new System.Drawing.Point(218, 198);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 17);
            this.label21.TabIndex = 8;
            this.label21.Text = "No. of Adult:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label22.Location = new System.Drawing.Point(18, 59);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 17);
            this.label22.TabIndex = 7;
            this.label22.Text = "Identity Number:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label23.Location = new System.Drawing.Point(353, 59);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 17);
            this.label23.TabIndex = 6;
            this.label23.Text = "Room Type:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label25.Location = new System.Drawing.Point(309, 140);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(155, 17);
            this.label25.TabIndex = 3;
            this.label25.Text = "Expect Check out Date:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label26.Location = new System.Drawing.Point(26, 92);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 17);
            this.label26.TabIndex = 2;
            this.label26.Text = "Check In Date:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label28.Location = new System.Drawing.Point(355, 17);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 17);
            this.label28.TabIndex = 1;
            this.label28.Text = "Room No. :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label32.Location = new System.Drawing.Point(34, 17);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(91, 17);
            this.label32.TabIndex = 0;
            this.label32.Text = "Guest Name:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnCOReset);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(-3, 390);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 127);
            this.panel3.TabIndex = 7;
            // 
            // btnCOReset
            // 
            this.btnCOReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCOReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOReset.ForeColor = System.Drawing.Color.White;
            this.btnCOReset.Location = new System.Drawing.Point(239, 37);
            this.btnCOReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnCOReset.Name = "btnCOReset";
            this.btnCOReset.Size = new System.Drawing.Size(81, 31);
            this.btnCOReset.TabIndex = 33;
            this.btnCOReset.Text = "Reset";
            this.btnCOReset.UseVisualStyleBackColor = false;
            this.btnCOReset.Click += new System.EventHandler(this.btnCOReset_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(340, 37);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(81, 31);
            this.btnCheckOut.TabIndex = 28;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label27.Location = new System.Drawing.Point(273, 8);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(147, 37);
            this.label27.TabIndex = 5;
            this.label27.Text = "Check Out";
            // 
            // tabCheckin
            // 
            this.tabCheckin.AutoScroll = true;
            this.tabCheckin.Controls.Add(this.panel1);
            this.tabCheckin.Controls.Add(this.lbCheckIn);
            this.tabCheckin.Controls.Add(this.panel2);
            this.tabCheckin.Location = new System.Drawing.Point(4, 22);
            this.tabCheckin.Name = "tabCheckin";
            this.tabCheckin.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckin.Size = new System.Drawing.Size(680, 505);
            this.tabCheckin.TabIndex = 0;
            this.tabCheckin.Text = "Checkin";
            this.tabCheckin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCheckIn);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 434);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 68);
            this.panel1.TabIndex = 5;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(362, 19);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(79, 31);
            this.btnCheckIn.TabIndex = 26;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(245, 19);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 31);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.lbCheckIn.Location = new System.Drawing.Point(290, 13);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(125, 37);
            this.lbCheckIn.TabIndex = 3;
            this.lbCheckIn.Text = "Check In";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtCIIdentityNo);
            this.panel2.Controls.Add(this.cbxCIGuestID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCiSearchRoom);
            this.panel2.Controls.Add(this.txtCIRoomRate);
            this.panel2.Controls.Add(this.txtCINoOccupancy);
            this.panel2.Controls.Add(this.txtCISubTotal);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.txtCIDays);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbxCIRoomNo);
            this.panel2.Controls.Add(this.cbxCIRoomType);
            this.panel2.Controls.Add(this.dtpCICheckInTime);
            this.panel2.Controls.Add(this.cbxCIGuestName);
            this.panel2.Controls.Add(this.ciNoChild);
            this.panel2.Controls.Add(this.ciNoAdult);
            this.panel2.Controls.Add(this.dtpCICheckoutTime);
            this.panel2.Controls.Add(this.txtCIPhone);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lable);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbGuestName);
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(678, 364);
            this.panel2.TabIndex = 4;
            // 
            // txtCIIdentityNo
            // 
            this.txtCIIdentityNo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "identityNumber", true));
            this.txtCIIdentityNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "identityNumber", true));
            this.txtCIIdentityNo.Location = new System.Drawing.Point(128, 65);
            this.txtCIIdentityNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCIIdentityNo.MaxLength = 12;
            this.txtCIIdentityNo.Name = "txtCIIdentityNo";
            this.txtCIIdentityNo.Size = new System.Drawing.Size(171, 20);
            this.txtCIIdentityNo.TabIndex = 49;
            this.txtCIIdentityNo.TextChanged += new System.EventHandler(this.txtCIIdentityNo_TextChanged);
            this.txtCIIdentityNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCIIdentityNo_KeyPress);
            this.txtCIIdentityNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCIIdentityNo_Validating);
            // 
            // cbxCIGuestID
            // 
            this.cbxCIGuestID.DataSource = this.guestBindingSource;
            this.cbxCIGuestID.DisplayMember = "guestId";
            this.cbxCIGuestID.Enabled = false;
            this.cbxCIGuestID.FormattingEnabled = true;
            this.cbxCIGuestID.Location = new System.Drawing.Point(129, 100);
            this.cbxCIGuestID.Name = "cbxCIGuestID";
            this.cbxCIGuestID.Size = new System.Drawing.Size(171, 21);
            this.cbxCIGuestID.TabIndex = 48;
            this.cbxCIGuestID.ValueMember = "guestId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Guest ID:";
            // 
            // btnCiSearchRoom
            // 
            this.btnCiSearchRoom.BackColor = System.Drawing.Color.White;
            this.btnCiSearchRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCiSearchRoom.BackgroundImage")));
            this.btnCiSearchRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCiSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiSearchRoom.Location = new System.Drawing.Point(608, 94);
            this.btnCiSearchRoom.Name = "btnCiSearchRoom";
            this.btnCiSearchRoom.Size = new System.Drawing.Size(27, 27);
            this.btnCiSearchRoom.TabIndex = 45;
            this.btnCiSearchRoom.UseVisualStyleBackColor = false;
            this.btnCiSearchRoom.Click += new System.EventHandler(this.btnCiSearchRoom_Click);
            // 
            // txtCIRoomRate
            // 
            this.txtCIRoomRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTypeBindingSource, "roomRate", true));
            this.txtCIRoomRate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.roomTypeBindingSource, "roomRate", true));
            this.txtCIRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIRoomRate.Location = new System.Drawing.Point(436, 137);
            this.txtCIRoomRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCIRoomRate.Name = "txtCIRoomRate";
            this.txtCIRoomRate.ReadOnly = true;
            this.txtCIRoomRate.Size = new System.Drawing.Size(159, 21);
            this.txtCIRoomRate.TabIndex = 44;
            this.txtCIRoomRate.Text = "0 VND";
            this.txtCIRoomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCIRoomRate.TextChanged += new System.EventHandler(this.txtCIRoomRate_TextChanged);
            // 
            // txtCINoOccupancy
            // 
            this.txtCINoOccupancy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomTypeBindingSource, "noOfOccupancy", true));
            this.txtCINoOccupancy.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.roomTypeBindingSource, "noOfOccupancy", true));
            this.txtCINoOccupancy.Location = new System.Drawing.Point(469, 176);
            this.txtCINoOccupancy.Margin = new System.Windows.Forms.Padding(2);
            this.txtCINoOccupancy.Name = "txtCINoOccupancy";
            this.txtCINoOccupancy.ReadOnly = true;
            this.txtCINoOccupancy.Size = new System.Drawing.Size(48, 20);
            this.txtCINoOccupancy.TabIndex = 39;
            // 
            // txtCISubTotal
            // 
            this.txtCISubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCISubTotal.Location = new System.Drawing.Point(506, 312);
            this.txtCISubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCISubTotal.Name = "txtCISubTotal";
            this.txtCISubTotal.ReadOnly = true;
            this.txtCISubTotal.Size = new System.Drawing.Size(129, 21);
            this.txtCISubTotal.TabIndex = 38;
            this.txtCISubTotal.Text = "0 VND";
            this.txtCISubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label30.Location = new System.Drawing.Point(419, 315);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 16);
            this.label30.TabIndex = 35;
            this.label30.Text = "Sub Total :";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCIDays
            // 
            this.txtCIDays.Location = new System.Drawing.Point(528, 247);
            this.txtCIDays.Margin = new System.Windows.Forms.Padding(2);
            this.txtCIDays.Name = "txtCIDays";
            this.txtCIDays.ReadOnly = true;
            this.txtCIDays.Size = new System.Drawing.Size(48, 20);
            this.txtCIDays.TabIndex = 33;
            this.txtCIDays.TextChanged += new System.EventHandler(this.txtCIDays_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label11.Location = new System.Drawing.Point(423, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "No. of Days:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(345, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "NoOfOccupancy :";
            // 
            // cbxCIRoomNo
            // 
            this.cbxCIRoomNo.DataSource = this.fkroomTypeBindingSource;
            this.cbxCIRoomNo.DisplayMember = "roomNo";
            this.cbxCIRoomNo.FormattingEnabled = true;
            this.cbxCIRoomNo.Location = new System.Drawing.Point(436, 98);
            this.cbxCIRoomNo.Name = "cbxCIRoomNo";
            this.cbxCIRoomNo.Size = new System.Drawing.Size(159, 21);
            this.cbxCIRoomNo.TabIndex = 29;
            this.cbxCIRoomNo.ValueMember = "roomNo";
            // 
            // cbxCIRoomType
            // 
            this.cbxCIRoomType.DataSource = this.roomTypeBindingSource;
            this.cbxCIRoomType.DisplayMember = "name";
            this.cbxCIRoomType.FormattingEnabled = true;
            this.cbxCIRoomType.Location = new System.Drawing.Point(436, 62);
            this.cbxCIRoomType.Name = "cbxCIRoomType";
            this.cbxCIRoomType.Size = new System.Drawing.Size(159, 21);
            this.cbxCIRoomType.TabIndex = 28;
            this.cbxCIRoomType.ValueMember = "roomTypeId";
            // 
            // dtpCICheckInTime
            // 
            this.dtpCICheckInTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpCICheckInTime.Enabled = false;
            this.dtpCICheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCICheckInTime.Location = new System.Drawing.Point(129, 211);
            this.dtpCICheckInTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCICheckInTime.Name = "dtpCICheckInTime";
            this.dtpCICheckInTime.Size = new System.Drawing.Size(124, 20);
            this.dtpCICheckInTime.TabIndex = 27;
            this.dtpCICheckInTime.ValueChanged += new System.EventHandler(this.dtpCICheckInTime_ValueChanged);
            // 
            // cbxCIGuestName
            // 
            this.cbxCIGuestName.DataSource = this.guestBindingSource;
            this.cbxCIGuestName.DisplayMember = "fullname";
            this.cbxCIGuestName.FormattingEnabled = true;
            this.cbxCIGuestName.Location = new System.Drawing.Point(129, 139);
            this.cbxCIGuestName.Name = "cbxCIGuestName";
            this.cbxCIGuestName.Size = new System.Drawing.Size(171, 21);
            this.cbxCIGuestName.TabIndex = 26;
            this.cbxCIGuestName.ValueMember = "fullname";
            this.cbxCIGuestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCIGuestName_KeyPress);
            // 
            // ciNoChild
            // 
            this.ciNoChild.Location = new System.Drawing.Point(141, 250);
            this.ciNoChild.Margin = new System.Windows.Forms.Padding(2);
            this.ciNoChild.Name = "ciNoChild";
            this.ciNoChild.Size = new System.Drawing.Size(52, 20);
            this.ciNoChild.TabIndex = 25;
            // 
            // ciNoAdult
            // 
            this.ciNoAdult.Location = new System.Drawing.Point(328, 252);
            this.ciNoAdult.Margin = new System.Windows.Forms.Padding(2);
            this.ciNoAdult.Name = "ciNoAdult";
            this.ciNoAdult.Size = new System.Drawing.Size(65, 20);
            this.ciNoAdult.TabIndex = 24;
            // 
            // dtpCICheckoutTime
            // 
            this.dtpCICheckoutTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpCICheckoutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCICheckoutTime.Location = new System.Drawing.Point(452, 211);
            this.dtpCICheckoutTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCICheckoutTime.Name = "dtpCICheckoutTime";
            this.dtpCICheckoutTime.Size = new System.Drawing.Size(124, 20);
            this.dtpCICheckoutTime.TabIndex = 18;
            this.dtpCICheckoutTime.ValueChanged += new System.EventHandler(this.dtpCICheckoutTime_ValueChanged);
            // 
            // txtCIPhone
            // 
            this.txtCIPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "phone", true));
            this.txtCIPhone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "phone", true));
            this.txtCIPhone.Location = new System.Drawing.Point(128, 176);
            this.txtCIPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCIPhone.MaxLength = 11;
            this.txtCIPhone.Name = "txtCIPhone";
            this.txtCIPhone.Size = new System.Drawing.Size(171, 20);
            this.txtCIPhone.TabIndex = 17;
            this.txtCIPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCIPhone_KeyPress);
            this.txtCIPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtCIPhone_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label14.Location = new System.Drawing.Point(348, 139);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(47, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "No. of Child:";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.lable.Location = new System.Drawing.Point(238, 253);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(86, 17);
            this.lable.TabIndex = 8;
            this.lable.Text = "No. of Adult:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(11, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Identity Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(346, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Room Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(342, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Check out Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(19, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(23, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check In Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(352, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room No. :";
            // 
            // lbGuestName
            // 
            this.lbGuestName.AutoSize = true;
            this.lbGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.lbGuestName.Location = new System.Drawing.Point(30, 142);
            this.lbGuestName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGuestName.Name = "lbGuestName";
            this.lbGuestName.Size = new System.Drawing.Size(91, 17);
            this.lbGuestName.TabIndex = 0;
            this.lbGuestName.Text = "Guest Name:";
            // 
            // tabControlCICO
            // 
            this.tabControlCICO.Controls.Add(this.tabCheckin);
            this.tabControlCICO.Controls.Add(this.tabCheckout);
            this.tabControlCICO.Controls.Add(this.tabListRoom);
            this.tabControlCICO.Location = new System.Drawing.Point(0, 16);
            this.tabControlCICO.Name = "tabControlCICO";
            this.tabControlCICO.SelectedIndex = 0;
            this.tabControlCICO.Size = new System.Drawing.Size(688, 531);
            this.tabControlCICO.TabIndex = 0;
            this.tabControlCICO.SelectedIndexChanged += new System.EventHandler(this.tabControlCICO_SelectedIndexChanged);
            // 
            // viewCheckinTableAdapter
            // 
            this.viewCheckinTableAdapter.ClearBeforeFill = true;
            // 
            // UcCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlCICO);
            this.Name = "UcCheckin";
            this.Size = new System.Drawing.Size(708, 567);
            this.Load += new System.EventHandler(this.UcCheckin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_HotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkroomTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.tabListRoom.ResumeLayout(false);
            this.tabListRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabCheckout.ResumeLayout(false);
            this.tabCheckout.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckinBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabCheckin.ResumeLayout(false);
            this.tabCheckin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciNoChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciNoAdult)).EndInit();
            this.tabControlCICO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PRN292_HotelDBDataSet pRN292_HotelDBDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private PRN292_HotelDBDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private PRN292_HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource roomTypeBindingSource;
        private PRN292_HotelDBDataSetTableAdapters.RoomTypeTableAdapter roomTypeTableAdapter;
        private System.Windows.Forms.BindingSource fkroomTypeBindingSource;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private PRN292_HotelDBDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private System.Windows.Forms.TabPage tabListRoom;
        private System.Windows.Forms.CheckBox cbLRAllRoomType;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbxRoomType;
        private System.Windows.Forms.ComboBox cbxVacant;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.TextBox txtSearchRoomNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabCheckout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCORoomType;
        private System.Windows.Forms.TextBox txtCOAdult;
        private System.Windows.Forms.TextBox txtCOChild;
        private System.Windows.Forms.TextBox txtCORoomRate;
        private System.Windows.Forms.TextBox txtCOTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCODays;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbxCORoomNo;
        private System.Windows.Forms.DateTimePicker dtpCOCheckinTime;
        private System.Windows.Forms.DateTimePicker dtpCOExpectCheckoutTime;
        private System.Windows.Forms.TextBox txtCOIdentityNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCOReset;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabCheckin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCIIdentityNo;
        private System.Windows.Forms.ComboBox cbxCIGuestID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCiSearchRoom;
        private System.Windows.Forms.TextBox txtCIRoomRate;
        private System.Windows.Forms.TextBox txtCINoOccupancy;
        private System.Windows.Forms.TextBox txtCISubTotal;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtCIDays;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCIRoomNo;
        private System.Windows.Forms.ComboBox cbxCIRoomType;
        private System.Windows.Forms.DateTimePicker dtpCICheckInTime;
        private System.Windows.Forms.ComboBox cbxCIGuestName;
        private System.Windows.Forms.NumericUpDown ciNoChild;
        private System.Windows.Forms.NumericUpDown ciNoAdult;
        private System.Windows.Forms.DateTimePicker dtpCICheckoutTime;
        private System.Windows.Forms.TextBox txtCIPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGuestName;
        private System.Windows.Forms.TabControl tabControlCICO;
        private System.Windows.Forms.DateTimePicker dtpCOCheckoutTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCOGuestName;
        private System.Windows.Forms.BindingSource viewCheckinBindingSource;
        private PRN292_HotelDBDataSetTableAdapters.ViewCheckinTableAdapter viewCheckinTableAdapter;
    }
}
