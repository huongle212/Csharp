
namespace PRN292_Lab7_More
{
    partial class FrmNhapDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMasv = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbxMamon = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.pRN292_QLSV_Lab7DataSet = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSet();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.MonHocTableAdapter();
            this.tableAdapterManager = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.SinhVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSV_Lab7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên môn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm:";
            // 
            // cbxMasv
            // 
            this.cbxMasv.DataSource = this.sinhVienBindingSource;
            this.cbxMasv.DisplayMember = "MaSV";
            this.cbxMasv.FormattingEnabled = true;
            this.cbxMasv.Location = new System.Drawing.Point(128, 36);
            this.cbxMasv.Name = "cbxMasv";
            this.cbxMasv.Size = new System.Drawing.Size(121, 21);
            this.cbxMasv.TabIndex = 5;
            this.cbxMasv.ValueMember = "MaSV";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.monHocBindingSource;
            this.comboBox2.DisplayMember = "TenMH";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(128, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "TenMH";
            // 
            // cbxMamon
            // 
            this.cbxMamon.DataSource = this.monHocBindingSource;
            this.cbxMamon.DisplayMember = "MaMH";
            this.cbxMamon.FormattingEnabled = true;
            this.cbxMamon.Location = new System.Drawing.Point(128, 114);
            this.cbxMamon.Name = "cbxMamon";
            this.cbxMamon.Size = new System.Drawing.Size(121, 21);
            this.cbxMamon.TabIndex = 8;
            this.cbxMamon.ValueMember = "MaMH";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.sinhVienBindingSource;
            this.comboBox5.DisplayMember = "HoTen";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(128, 73);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(177, 21);
            this.comboBox5.TabIndex = 9;
            this.comboBox5.ValueMember = "HoTen";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(128, 189);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(89, 20);
            this.txtDiem.TabIndex = 10;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(216, 232);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 11;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // pRN292_QLSV_Lab7DataSet
            // 
            this.pRN292_QLSV_Lab7DataSet.DataSetName = "PRN292_QLSV_Lab7DataSet";
            this.pRN292_QLSV_Lab7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.pRN292_QLSV_Lab7DataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = this.monHocTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.pRN292_QLSV_Lab7DataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 274);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.cbxMamon);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cbxMasv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.FrmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSV_Lab7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMasv;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbxMamon;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnNhap;
        private PRN292_QLSV_Lab7DataSet pRN292_QLSV_Lab7DataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private PRN292_QLSV_Lab7DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PRN292_QLSV_Lab7DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
    }
}