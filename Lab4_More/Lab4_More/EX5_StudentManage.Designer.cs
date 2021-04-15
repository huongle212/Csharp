
namespace Lab4_More
{
    partial class EX5_StudentManage
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
            this.btnMoveAllL = new System.Windows.Forms.Button();
            this.btnMoveAllR = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbClassB = new System.Windows.Forms.ListBox();
            this.lbClassA = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMoveAllL
            // 
            this.btnMoveAllL.Location = new System.Drawing.Point(263, 198);
            this.btnMoveAllL.Name = "btnMoveAllL";
            this.btnMoveAllL.Size = new System.Drawing.Size(40, 23);
            this.btnMoveAllL.TabIndex = 23;
            this.btnMoveAllL.Text = "<<";
            this.btnMoveAllL.UseVisualStyleBackColor = true;
            this.btnMoveAllL.Click += new System.EventHandler(this.btnMoveAllL_Click);
            // 
            // btnMoveAllR
            // 
            this.btnMoveAllR.Location = new System.Drawing.Point(214, 198);
            this.btnMoveAllR.Name = "btnMoveAllR";
            this.btnMoveAllR.Size = new System.Drawing.Size(43, 23);
            this.btnMoveAllR.TabIndex = 22;
            this.btnMoveAllR.Text = ">>";
            this.btnMoveAllR.UseVisualStyleBackColor = true;
            this.btnMoveAllR.Click += new System.EventHandler(this.btnMoveAllR_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(263, 147);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(40, 23);
            this.btnMoveLeft.TabIndex = 21;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(214, 147);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(43, 23);
            this.btnMoveRight.TabIndex = 20;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(285, 295);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 19;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(105, 295);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbClassB
            // 
            this.lbClassB.FormattingEnabled = true;
            this.lbClassB.Location = new System.Drawing.Point(309, 117);
            this.lbClassB.Name = "lbClassB";
            this.lbClassB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbClassB.Size = new System.Drawing.Size(184, 160);
            this.lbClassB.TabIndex = 17;
            // 
            // lbClassA
            // 
            this.lbClassA.FormattingEnabled = true;
            this.lbClassA.Items.AddRange(new object[] {
            "Huỳnh Phương Anh",
            "Lưu Tấn Đức",
            "Trần Anh Khoa",
            "Lê Hoàng Hà",
            "Phan Anh Hào",
            "Hoàng Hồ Nam",
            "Lê Anh Trung"});
            this.lbClassA.Location = new System.Drawing.Point(24, 117);
            this.lbClassA.Name = "lbClassA";
            this.lbClassA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbClassA.Size = new System.Drawing.Size(184, 160);
            this.lbClassA.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(56, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 13);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Họ và tên";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(102, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(294, 29);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "DANH SÁCH SINH VIÊN";
            // 
            // EX5_StudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 330);
            this.Controls.Add(this.btnMoveAllL);
            this.Controls.Add(this.btnMoveAllR);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lbClassB);
            this.Controls.Add(this.lbClassA);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.Name = "EX5_StudentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX5_StudentManage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveAllL;
        private System.Windows.Forms.Button btnMoveAllR;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox lbClassB;
        private System.Windows.Forms.ListBox lbClassA;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTitle;
    }
}