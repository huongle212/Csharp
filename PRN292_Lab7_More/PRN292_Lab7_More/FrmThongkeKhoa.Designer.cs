
namespace PRN292_Lab7_More
{
    partial class FrmThongkeKhoa
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
            this.btnXem = new System.Windows.Forms.Button();
            this.cbxMakhoa = new System.Windows.Forms.ComboBox();
            this.cbxTenkhoa = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRN292_QLSV_Lab7DataSet = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSet();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.KhoaTableAdapter();
            this.tableAdapterManager = new PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSV_Lab7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa: ";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(594, 20);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbxMakhoa
            // 
            this.cbxMakhoa.DataSource = this.khoaBindingSource;
            this.cbxMakhoa.DisplayMember = "MaKhoa";
            this.cbxMakhoa.FormattingEnabled = true;
            this.cbxMakhoa.Location = new System.Drawing.Point(92, 22);
            this.cbxMakhoa.Name = "cbxMakhoa";
            this.cbxMakhoa.Size = new System.Drawing.Size(121, 21);
            this.cbxMakhoa.TabIndex = 3;
            this.cbxMakhoa.ValueMember = "MaKhoa";
            // 
            // cbxTenkhoa
            // 
            this.cbxTenkhoa.DataSource = this.khoaBindingSource;
            this.cbxTenkhoa.DisplayMember = "TenKhoa";
            this.cbxTenkhoa.FormattingEnabled = true;
            this.cbxTenkhoa.Location = new System.Drawing.Point(307, 22);
            this.cbxTenkhoa.Name = "cbxTenkhoa";
            this.cbxTenkhoa.Size = new System.Drawing.Size(261, 21);
            this.cbxTenkhoa.TabIndex = 4;
            this.cbxTenkhoa.ValueMember = "TenKhoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 222);
            this.dataGridView1.TabIndex = 5;
            // 
            // pRN292_QLSV_Lab7DataSet
            // 
            this.pRN292_QLSV_Lab7DataSet.DataSetName = "PRN292_QLSV_Lab7DataSet";
            this.pRN292_QLSV_Lab7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.pRN292_QLSV_Lab7DataSet;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = this.khoaTableAdapter;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRN292_Lab7_More.PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmThongkeKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxTenkhoa);
            this.Controls.Add(this.cbxMakhoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThongkeKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem sinh viên theo khoa";
            this.Load += new System.EventHandler(this.FrmThongkeKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSV_Lab7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbxMakhoa;
        private System.Windows.Forms.ComboBox cbxTenkhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PRN292_QLSV_Lab7DataSet pRN292_QLSV_Lab7DataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private PRN292_QLSV_Lab7DataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private PRN292_QLSV_Lab7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}