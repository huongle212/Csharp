
namespace PRN292_W8_DemoCSDL
{
    partial class Bai1_3_TruyvanCSDL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemTt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputMalop = new System.Windows.Forms.TextBox();
            this.lsvSinhvien = new System.Windows.Forms.ListView();
            this.colMasv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTensv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMalop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXemDstv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenlop);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.txtMalop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 193);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp";
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(79, 80);
            this.txtTenlop.Multiline = true;
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.ReadOnly = true;
            this.txtTenlop.Size = new System.Drawing.Size(161, 52);
            this.txtTenlop.TabIndex = 11;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(79, 150);
            this.txtNam.Name = "txtNam";
            this.txtNam.ReadOnly = true;
            this.txtNam.Size = new System.Drawing.Size(161, 20);
            this.txtNam.TabIndex = 10;
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(79, 37);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.ReadOnly = true;
            this.txtMalop.Size = new System.Drawing.Size(161, 20);
            this.txtMalop.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Năm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên lớp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã lớp :";
            // 
            // btnXemTt
            // 
            this.btnXemTt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTt.Location = new System.Drawing.Point(269, 25);
            this.btnXemTt.Name = "btnXemTt";
            this.btnXemTt.Size = new System.Drawing.Size(142, 31);
            this.btnXemTt.TabIndex = 8;
            this.btnXemTt.Text = "Xem thông tin về lớp";
            this.btnXemTt.UseVisualStyleBackColor = true;
            this.btnXemTt.Click += new System.EventHandler(this.btnXemTt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập mã lớp";
            // 
            // txtInputMalop
            // 
            this.txtInputMalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMalop.Location = new System.Drawing.Point(116, 29);
            this.txtInputMalop.Name = "txtInputMalop";
            this.txtInputMalop.Size = new System.Drawing.Size(137, 22);
            this.txtInputMalop.TabIndex = 6;
            // 
            // lsvSinhvien
            // 
            this.lsvSinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMasv,
            this.colTensv,
            this.colMalop});
            this.lsvSinhvien.FullRowSelect = true;
            this.lsvSinhvien.GridLines = true;
            this.lsvSinhvien.HideSelection = false;
            this.lsvSinhvien.Location = new System.Drawing.Point(284, 91);
            this.lsvSinhvien.Name = "lsvSinhvien";
            this.lsvSinhvien.Size = new System.Drawing.Size(334, 183);
            this.lsvSinhvien.TabIndex = 11;
            this.lsvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhvien.View = System.Windows.Forms.View.Details;
            // 
            // colMasv
            // 
            this.colMasv.Text = "Mã sinh viên";
            this.colMasv.Width = 86;
            // 
            // colTensv
            // 
            this.colTensv.Text = "Họ và tên";
            this.colTensv.Width = 182;
            // 
            // colMalop
            // 
            this.colMalop.Text = "Mã lớp";
            // 
            // btnXemDstv
            // 
            this.btnXemDstv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDstv.Location = new System.Drawing.Point(417, 25);
            this.btnXemDstv.Name = "btnXemDstv";
            this.btnXemDstv.Size = new System.Drawing.Size(185, 31);
            this.btnXemDstv.TabIndex = 10;
            this.btnXemDstv.Text = "Xem danh sách thành viên";
            this.btnXemDstv.UseVisualStyleBackColor = true;
            this.btnXemDstv.Click += new System.EventHandler(this.btnXemDstv_Click);
            // 
            // Bai1_3_TruyvanCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXemTt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputMalop);
            this.Controls.Add(this.lsvSinhvien);
            this.Controls.Add(this.btnXemDstv);
            this.Name = "Bai1_3_TruyvanCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Truy vấn CSDL 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemTt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputMalop;
        private System.Windows.Forms.ListView lsvSinhvien;
        private System.Windows.Forms.ColumnHeader colMasv;
        private System.Windows.Forms.ColumnHeader colTensv;
        private System.Windows.Forms.ColumnHeader colMalop;
        private System.Windows.Forms.Button btnXemDstv;
    }
}