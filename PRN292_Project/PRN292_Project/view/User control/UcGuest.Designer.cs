
namespace PRN292_Project.view
{
    partial class UcGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcGuest));
            this.label6 = new System.Windows.Forms.Label();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRN292_HotelDBDataSet = new PRN292_Project.PRN292_HotelDBDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Label();
            this.grRoomInfor = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbxIdentityNo = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbxGuestId = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFullname = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvGuest = new System.Windows.Forms.DataGridView();
            this.txtSearchGuest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guestTableAdapter = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.GuestTableAdapter();
            this.tableAdapterManager = new PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager();
            this.cbFilterGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_HotelDBDataSet)).BeginInit();
            this.grRoomInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Address :";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Identity Number :";
            // 
            // Guest
            // 
            this.Guest.AutoSize = true;
            this.Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest.Location = new System.Drawing.Point(17, 22);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(202, 26);
            this.Guest.TabIndex = 34;
            this.Guest.Text = "Guest Information";
            // 
            // grRoomInfor
            // 
            this.grRoomInfor.Controls.Add(this.txtAddress);
            this.grRoomInfor.Controls.Add(this.cbxIdentityNo);
            this.grRoomInfor.Controls.Add(this.cbGender);
            this.grRoomInfor.Controls.Add(this.label1);
            this.grRoomInfor.Controls.Add(this.txtPhone);
            this.grRoomInfor.Controls.Add(this.cbxGuestId);
            this.grRoomInfor.Controls.Add(this.label6);
            this.grRoomInfor.Controls.Add(this.label5);
            this.grRoomInfor.Controls.Add(this.label2);
            this.grRoomInfor.Controls.Add(this.btnPrevious);
            this.grRoomInfor.Controls.Add(this.btnNext);
            this.grRoomInfor.Controls.Add(this.btnAdd);
            this.grRoomInfor.Controls.Add(this.btnCancel);
            this.grRoomInfor.Controls.Add(this.btnUpdate);
            this.grRoomInfor.Controls.Add(this.btnDelete);
            this.grRoomInfor.Controls.Add(this.label4);
            this.grRoomInfor.Controls.Add(this.cbxFullname);
            this.grRoomInfor.Controls.Add(this.label10);
            this.grRoomInfor.Location = new System.Drawing.Point(24, 65);
            this.grRoomInfor.Name = "grRoomInfor";
            this.grRoomInfor.Size = new System.Drawing.Size(647, 221);
            this.grRoomInfor.TabIndex = 35;
            this.grRoomInfor.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "address", true));
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "address", true));
            this.txtAddress.Location = new System.Drawing.Point(377, 25);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(235, 113);
            this.txtAddress.TabIndex = 34;
            // 
            // cbxIdentityNo
            // 
            this.cbxIdentityNo.DataSource = this.guestBindingSource;
            this.cbxIdentityNo.DisplayMember = "identityNumber";
            this.cbxIdentityNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdentityNo.FormattingEnabled = true;
            this.cbxIdentityNo.Location = new System.Drawing.Point(121, 107);
            this.cbxIdentityNo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxIdentityNo.MaxLength = 12;
            this.cbxIdentityNo.Name = "cbxIdentityNo";
            this.cbxIdentityNo.Size = new System.Drawing.Size(166, 23);
            this.cbxIdentityNo.TabIndex = 33;
            this.cbxIdentityNo.ValueMember = "identityNumber";
            this.cbxIdentityNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxIdentityNo_KeyPress);
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "gender", true));
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.guestBindingSource, "gender", true));
            this.cbGender.Location = new System.Drawing.Point(388, 145);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(49, 17);
            this.cbGender.TabIndex = 32;
            this.cbGender.Text = "Male";
            this.cbGender.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Gender :";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "phone", true));
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.guestBindingSource, "phone", true));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(121, 143);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 21);
            this.txtPhone.TabIndex = 30;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // cbxGuestId
            // 
            this.cbxGuestId.DataSource = this.guestBindingSource;
            this.cbxGuestId.DisplayMember = "guestId";
            this.cbxGuestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGuestId.FormattingEnabled = true;
            this.cbxGuestId.Location = new System.Drawing.Point(121, 26);
            this.cbxGuestId.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGuestId.Name = "cbxGuestId";
            this.cbxGuestId.Size = new System.Drawing.Size(132, 23);
            this.cbxGuestId.TabIndex = 28;
            this.cbxGuestId.ValueMember = "guestId";
            this.cbxGuestId.TextChanged += new System.EventHandler(this.cbxGuestId_TextChanged);
            this.cbxGuestId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxGuestId_KeyPress);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(2, 8);
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
            this.btnNext.Location = new System.Drawing.Point(618, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(271, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(271, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(150, 178);
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
            this.btnDelete.Location = new System.Drawing.Point(388, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Guest ID :";
            // 
            // cbxFullname
            // 
            this.cbxFullname.DataSource = this.guestBindingSource;
            this.cbxFullname.DisplayMember = "fullname";
            this.cbxFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFullname.FormattingEnabled = true;
            this.cbxFullname.Location = new System.Drawing.Point(121, 68);
            this.cbxFullname.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFullname.Name = "cbxFullname";
            this.cbxFullname.Size = new System.Drawing.Size(166, 23);
            this.cbxFullname.TabIndex = 4;
            this.cbxFullname.ValueMember = "fullname";
            this.cbxFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxFullname_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fullname :";
            // 
            // dgvGuest
            // 
            this.dgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuest.Location = new System.Drawing.Point(24, 308);
            this.dgvGuest.Name = "dgvGuest";
            this.dgvGuest.ReadOnly = true;
            this.dgvGuest.Size = new System.Drawing.Size(647, 217);
            this.dgvGuest.TabIndex = 36;
            this.dgvGuest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuest_CellClick);
            // 
            // txtSearchGuest
            // 
            this.txtSearchGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGuest.Location = new System.Drawing.Point(412, 38);
            this.txtSearchGuest.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchGuest.Name = "txtSearchGuest";
            this.txtSearchGuest.Size = new System.Drawing.Size(159, 22);
            this.txtSearchGuest.TabIndex = 38;
            this.txtSearchGuest.TextChanged += new System.EventHandler(this.txtSearchGuest_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Search";
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CheckinTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = this.guestTableAdapter;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRN292_Project.PRN292_HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbFilterGender
            // 
            this.cbFilterGender.BackColor = System.Drawing.Color.White;
            this.cbFilterGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterGender.FormattingEnabled = true;
            this.cbFilterGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "All"});
            this.cbFilterGender.Location = new System.Drawing.Point(594, 37);
            this.cbFilterGender.Name = "cbFilterGender";
            this.cbFilterGender.Size = new System.Drawing.Size(77, 21);
            this.cbFilterGender.TabIndex = 39;
            this.cbFilterGender.SelectedIndexChanged += new System.EventHandler(this.cbFilterGender_SelectedIndexChanged);
            // 
            // UcGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbFilterGender);
            this.Controls.Add(this.Guest);
            this.Controls.Add(this.grRoomInfor);
            this.Controls.Add(this.dgvGuest);
            this.Controls.Add(this.txtSearchGuest);
            this.Controls.Add(this.label3);
            this.Name = "UcGuest";
            this.Size = new System.Drawing.Size(691, 547);
            this.Load += new System.EventHandler(this.UcGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_HotelDBDataSet)).EndInit();
            this.grRoomInfor.ResumeLayout(false);
            this.grRoomInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Guest;
        private System.Windows.Forms.GroupBox grRoomInfor;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbxGuestId;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFullname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvGuest;
        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private PRN292_HotelDBDataSet pRN292_HotelDBDataSet;
        private PRN292_HotelDBDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private PRN292_HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbFilterGender;
        private System.Windows.Forms.ComboBox cbxIdentityNo;
        private System.Windows.Forms.TextBox txtAddress;
    }
}
