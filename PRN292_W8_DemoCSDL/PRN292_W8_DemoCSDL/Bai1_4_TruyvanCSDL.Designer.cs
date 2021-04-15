
namespace PRN292_W8_DemoCSDL
{
    partial class Bai1_4_TruyvanCSDL
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
            this.lsvSinhvien = new System.Windows.Forms.ListView();
            this.colMasv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMalop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsLop = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lsvSinhvien
            // 
            this.lsvSinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMasv,
            this.colTen,
            this.colMalop});
            this.lsvSinhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvSinhvien.FullRowSelect = true;
            this.lsvSinhvien.GridLines = true;
            this.lsvSinhvien.HideSelection = false;
            this.lsvSinhvien.Location = new System.Drawing.Point(314, 52);
            this.lsvSinhvien.Name = "lsvSinhvien";
            this.lsvSinhvien.Size = new System.Drawing.Size(346, 251);
            this.lsvSinhvien.TabIndex = 7;
            this.lsvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhvien.View = System.Windows.Forms.View.Details;
            // 
            // colMasv
            // 
            this.colMasv.Text = "Mã sinh viên";
            this.colMasv.Width = 92;
            // 
            // colTen
            // 
            this.colTen.Text = "Họ và tên";
            this.colTen.Width = 179;
            // 
            // colMalop
            // 
            this.colMalop.Text = "Mã Lớp";
            this.colMalop.Width = 70;
            // 
            // lsLop
            // 
            this.lsLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsLop.FormattingEnabled = true;
            this.lsLop.ItemHeight = 16;
            this.lsLop.Location = new System.Drawing.Point(26, 52);
            this.lsLop.Name = "lsLop";
            this.lsLop.Size = new System.Drawing.Size(259, 244);
            this.lsLop.TabIndex = 6;
            this.lsLop.SelectedIndexChanged += new System.EventHandler(this.lsLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách Sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách lớp";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(134, 66);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 8;
            // 
            // Bai1_4_TruyvanCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 320);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lsvSinhvien);
            this.Controls.Add(this.lsLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai1_4_TruyvanCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Truy vấn CSDL 3";
            this.Load += new System.EventHandler(this.Bai1_4_TruyvanCSDL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvSinhvien;
        private System.Windows.Forms.ColumnHeader colMasv;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colMalop;
        private System.Windows.Forms.ListBox lsLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}