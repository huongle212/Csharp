
namespace PRN292_Lab7_More
{
    partial class FrmXemDiem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.cbxTenSV = new System.Windows.Forms.ComboBox();
            this.cbxMaSV = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.pRN292_QLSV_Lab7DataSet = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSet();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSV_Lab7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 190);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtKhoa
            // 
            this.txtKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaKhoa", true));
            this.txtKhoa.Location = new System.Drawing.Point(112, 106);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(187, 20);
            this.txtKhoa.TabIndex = 4;
            // 
            // cbxTenSV
            // 
            this.cbxTenSV.DataSource = this.sinhVienBindingSource;
            this.cbxTenSV.DisplayMember = "HoTen";
            this.cbxTenSV.FormattingEnabled = true;
            this.cbxTenSV.Location = new System.Drawing.Point(112, 71);
            this.cbxTenSV.Name = "cbxTenSV";
            this.cbxTenSV.Size = new System.Drawing.Size(187, 21);
            this.cbxTenSV.TabIndex = 5;
            this.cbxTenSV.ValueMember = "MaSV";
            // 
            // cbxMaSV
            // 
            this.cbxMaSV.DataSource = this.sinhVienBindingSource;
            this.cbxMaSV.DisplayMember = "MaSV";
            this.cbxMaSV.FormattingEnabled = true;
            this.cbxMaSV.Location = new System.Drawing.Point(112, 40);
            this.cbxMaSV.Name = "cbxMaSV";
            this.cbxMaSV.Size = new System.Drawing.Size(187, 21);
            this.cbxMaSV.TabIndex = 6;
            this.cbxMaSV.ValueMember = "MaSV";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(317, 103);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // pRN292_QLSV_Lab7DataSet
            // 
            this.pRN292_QLSV_Lab7DataSet.DataSetName = "PRN292_QLSV_Lab7DataSet";
            this.pRN292_QLSV_Lab7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 362);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbxMaSV);
            this.Controls.Add(this.cbxTenSV);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm";
            this.Load += new System.EventHandler(this.FrmXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSV_Lab7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.ComboBox cbxTenSV;
        private System.Windows.Forms.ComboBox cbxMaSV;
        private System.Windows.Forms.Button btnXem;
        private PRN292_QLSV_Lab7DataSet pRN292_QLSV_Lab7DataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private PRN292_QLSV_Lab7DataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}