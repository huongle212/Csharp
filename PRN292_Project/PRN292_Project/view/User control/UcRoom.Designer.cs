
namespace PRN292_Project.view.User_control
{
    partial class UcRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRoom));
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grRoomInfor = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbVacant = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRoomType = new System.Windows.Forms.ComboBox();
            this.roomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRN292_HotelDBDataSet = new PRN292_Project.PRN292_HotelDBDataSet();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.txtSearchRoomType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager();
            this.roomTypeTableAdapter = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.RoomTypeTableAdapter();
            this.cbFilterRoom = new System.Windows.Forms.ComboBox();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestTableAdapter = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.GuestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.grRoomInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_HotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(360, 66);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(317, 221);
            this.dgvRoom.TabIndex = 19;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(100, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(53, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(100, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Room";
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoom.Location = new System.Drawing.Point(450, 28);
            this.txtSearchRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(137, 22);
            this.txtSearchRoom.TabIndex = 18;
            this.txtSearchRoom.TextChanged += new System.EventHandler(this.txtSearchRoom_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(158, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grRoomInfor
            // 
            this.grRoomInfor.Controls.Add(this.btnPrevious);
            this.grRoomInfor.Controls.Add(this.btnNext);
            this.grRoomInfor.Controls.Add(this.btnAdd);
            this.grRoomInfor.Controls.Add(this.cbVacant);
            this.grRoomInfor.Controls.Add(this.btnCancel);
            this.grRoomInfor.Controls.Add(this.btnUpdate);
            this.grRoomInfor.Controls.Add(this.btnDelete);
            this.grRoomInfor.Controls.Add(this.label4);
            this.grRoomInfor.Controls.Add(this.cbxRoomType);
            this.grRoomInfor.Controls.Add(this.txtRoomNo);
            this.grRoomInfor.Controls.Add(this.label10);
            this.grRoomInfor.Location = new System.Drawing.Point(30, 59);
            this.grRoomInfor.Name = "grRoomInfor";
            this.grRoomInfor.Size = new System.Drawing.Size(290, 221);
            this.grRoomInfor.TabIndex = 20;
            this.grRoomInfor.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(6, 192);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(27, 23);
            this.btnPrevious.TabIndex = 21;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(255, 192);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbVacant
            // 
            this.cbVacant.AutoSize = true;
            this.cbVacant.Checked = true;
            this.cbVacant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVacant.Enabled = false;
            this.cbVacant.Location = new System.Drawing.Point(121, 110);
            this.cbVacant.Name = "cbVacant";
            this.cbVacant.Size = new System.Drawing.Size(60, 17);
            this.cbVacant.TabIndex = 19;
            this.cbVacant.Text = "Vacant";
            this.cbVacant.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Room No :";
            // 
            // cbxRoomType
            // 
            this.cbxRoomType.DataSource = this.roomTypeBindingSource;
            this.cbxRoomType.DisplayMember = "name";
            this.cbxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRoomType.FormattingEnabled = true;
            this.cbxRoomType.Location = new System.Drawing.Point(121, 68);
            this.cbxRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRoomType.Name = "cbxRoomType";
            this.cbxRoomType.Size = new System.Drawing.Size(142, 24);
            this.cbxRoomType.TabIndex = 4;
            this.cbxRoomType.ValueMember = "roomTypeId";
            this.cbxRoomType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxRoomType_KeyPress);
            // 
            // roomTypeBindingSource
            // 
            this.roomTypeBindingSource.DataMember = "RoomType";
            this.roomTypeBindingSource.DataSource = this.pRN292_HotelDBDataSet;
            // 
            // pRN292_HotelDBDataSet
            // 
            this.pRN292_HotelDBDataSet.DataSetName = "PRN292_HotelDBDataSet";
            this.pRN292_HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(121, 30);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(142, 22);
            this.txtRoomNo.TabIndex = 2;
            this.txtRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            this.txtRoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomNo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Room Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search Room:";
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomType.Location = new System.Drawing.Point(31, 333);
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.ReadOnly = true;
            this.dgvRoomType.Size = new System.Drawing.Size(647, 191);
            this.dgvRoomType.TabIndex = 22;
            // 
            // txtSearchRoomType
            // 
            this.txtSearchRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoomType.Location = new System.Drawing.Point(160, 306);
            this.txtSearchRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRoomType.Name = "txtSearchRoomType";
            this.txtSearchRoomType.Size = new System.Drawing.Size(159, 22);
            this.txtSearchRoomType.TabIndex = 24;
            this.txtSearchRoomType.TextChanged += new System.EventHandler(this.txtSearchType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Search Room Type:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckinTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.HistoryLogTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = this.roomTypeTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomTypeTableAdapter
            // 
            this.roomTypeTableAdapter.ClearBeforeFill = true;
            // 
            // cbFilterRoom
            // 
            this.cbFilterRoom.BackColor = System.Drawing.Color.White;
            this.cbFilterRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRoom.FormattingEnabled = true;
            this.cbFilterRoom.Items.AddRange(new object[] {
            "Occupied",
            "Vacant",
            "All"});
            this.cbFilterRoom.Location = new System.Drawing.Point(603, 28);
            this.cbFilterRoom.Name = "cbFilterRoom";
            this.cbFilterRoom.Size = new System.Drawing.Size(77, 21);
            this.cbFilterRoom.TabIndex = 25;
            this.cbFilterRoom.SelectedIndexChanged += new System.EventHandler(this.cbFilterRoom_SelectedIndexChanged);
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.pRN292_HotelDBDataSet;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // UcRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbFilterRoom);
            this.Controls.Add(this.txtSearchRoomType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRoomType);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchRoom);
            this.Controls.Add(this.grRoomInfor);
            this.Controls.Add(this.label2);
            this.Name = "UcRoom";
            this.Size = new System.Drawing.Size(700, 551);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.grRoomInfor.ResumeLayout(false);
            this.grRoomInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_HotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grRoomInfor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRoomType;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoomType;
        private System.Windows.Forms.TextBox txtSearchRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbVacant;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.BindingSource roomTypeBindingSource;
        private PRN292_HotelDBDataSet pRN292_HotelDBDataSet;
        private PRN292_HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PRN292_HotelDBDataSetTableAdapters.RoomTypeTableAdapter roomTypeTableAdapter;
        private System.Windows.Forms.ComboBox cbFilterRoom;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private PRN292_HotelDBDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
    }
}
