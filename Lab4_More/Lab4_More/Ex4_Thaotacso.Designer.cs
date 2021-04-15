
namespace Lab4_More
{
    partial class Ex4_Thaotacso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.grbFunc = new System.Windows.Forms.GroupBox();
            this.btnDelLastNum = new System.Windows.Forms.Button();
            this.btnDelFirstNum = new System.Windows.Forms.Button();
            this.btnDelSelectedNum = new System.Windows.Forms.Button();
            this.btnLastOddNum = new System.Windows.Forms.Button();
            this.btnFirstEvenNum = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.grbFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(103, 29);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(152, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(279, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Items.AddRange(new object[] {
            "1",
            "12",
            "4",
            "5",
            "6",
            "54"});
            this.lstResult.Location = new System.Drawing.Point(27, 83);
            this.lstResult.Name = "lstResult";
            this.lstResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstResult.Size = new System.Drawing.Size(137, 212);
            this.lstResult.TabIndex = 3;
            // 
            // grbFunc
            // 
            this.grbFunc.Controls.Add(this.btnDelLastNum);
            this.grbFunc.Controls.Add(this.btnDelFirstNum);
            this.grbFunc.Controls.Add(this.btnDelSelectedNum);
            this.grbFunc.Controls.Add(this.btnLastOddNum);
            this.grbFunc.Controls.Add(this.btnFirstEvenNum);
            this.grbFunc.Controls.Add(this.btnAdd2);
            this.grbFunc.Location = new System.Drawing.Point(170, 83);
            this.grbFunc.Name = "grbFunc";
            this.grbFunc.Size = new System.Drawing.Size(184, 212);
            this.grbFunc.TabIndex = 5;
            this.grbFunc.TabStop = false;
            this.grbFunc.Text = "Chức năng";
            // 
            // btnDelLastNum
            // 
            this.btnDelLastNum.Location = new System.Drawing.Point(6, 173);
            this.btnDelLastNum.Name = "btnDelLastNum";
            this.btnDelLastNum.Size = new System.Drawing.Size(172, 23);
            this.btnDelLastNum.TabIndex = 11;
            this.btnDelLastNum.Text = "Xóa phần tử cuối";
            this.btnDelLastNum.UseVisualStyleBackColor = true;
            this.btnDelLastNum.Click += new System.EventHandler(this.btnDelLastNum_Click);
            // 
            // btnDelFirstNum
            // 
            this.btnDelFirstNum.Location = new System.Drawing.Point(6, 144);
            this.btnDelFirstNum.Name = "btnDelFirstNum";
            this.btnDelFirstNum.Size = new System.Drawing.Size(172, 23);
            this.btnDelFirstNum.TabIndex = 10;
            this.btnDelFirstNum.Text = "Xóa phần tử đầu";
            this.btnDelFirstNum.UseVisualStyleBackColor = true;
            this.btnDelFirstNum.Click += new System.EventHandler(this.btnDelFirstNum_Click);
            // 
            // btnDelSelectedNum
            // 
            this.btnDelSelectedNum.Location = new System.Drawing.Point(6, 115);
            this.btnDelSelectedNum.Name = "btnDelSelectedNum";
            this.btnDelSelectedNum.Size = new System.Drawing.Size(172, 23);
            this.btnDelSelectedNum.TabIndex = 9;
            this.btnDelSelectedNum.Text = "Xóa phần tử đang chọn";
            this.btnDelSelectedNum.UseVisualStyleBackColor = true;
            this.btnDelSelectedNum.Click += new System.EventHandler(this.btnDelSelectedNum_Click);
            // 
            // btnLastOddNum
            // 
            this.btnLastOddNum.Location = new System.Drawing.Point(6, 86);
            this.btnLastOddNum.Name = "btnLastOddNum";
            this.btnLastOddNum.Size = new System.Drawing.Size(172, 23);
            this.btnLastOddNum.TabIndex = 8;
            this.btnLastOddNum.Text = "Chọn số lẻ cuối";
            this.btnLastOddNum.UseVisualStyleBackColor = true;
            this.btnLastOddNum.Click += new System.EventHandler(this.btnLastOddNum_Click);
            // 
            // btnFirstEvenNum
            // 
            this.btnFirstEvenNum.Location = new System.Drawing.Point(6, 57);
            this.btnFirstEvenNum.Name = "btnFirstEvenNum";
            this.btnFirstEvenNum.Size = new System.Drawing.Size(172, 23);
            this.btnFirstEvenNum.TabIndex = 7;
            this.btnFirstEvenNum.Text = "Chọn số chẵn đầu tiên";
            this.btnFirstEvenNum.UseVisualStyleBackColor = true;
            this.btnFirstEvenNum.Click += new System.EventHandler(this.btnFirstEvenNum_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(6, 28);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(172, 23);
            this.btnAdd2.TabIndex = 6;
            this.btnAdd2.Text = "Tăng mỗi phần tử lên 2";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(27, 318);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(327, 23);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Ex4_Thaotacso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 353);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.grbFunc);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "Ex4_Thaotacso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thao tác số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ex4_Thaotacso_FormClosing);
            this.grbFunc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.GroupBox grbFunc;
        private System.Windows.Forms.Button btnDelLastNum;
        private System.Windows.Forms.Button btnDelFirstNum;
        private System.Windows.Forms.Button btnDelSelectedNum;
        private System.Windows.Forms.Button btnLastOddNum;
        private System.Windows.Forms.Button btnFirstEvenNum;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnEnd;
    }
}