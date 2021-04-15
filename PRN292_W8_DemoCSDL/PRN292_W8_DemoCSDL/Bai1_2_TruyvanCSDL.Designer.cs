
namespace PRN292_W8_DemoCSDL
{
    partial class Bai1_2_TruyvanCSDL
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
            this.lbKetqua = new System.Windows.Forms.Label();
            this.btnTinhsl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKetqua
            // 
            this.lbKetqua.AutoSize = true;
            this.lbKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetqua.Location = new System.Drawing.Point(295, 60);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(14, 15);
            this.lbKetqua.TabIndex = 3;
            this.lbKetqua.Text = "?";
            // 
            // btnTinhsl
            // 
            this.btnTinhsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhsl.Location = new System.Drawing.Point(62, 47);
            this.btnTinhsl.Name = "btnTinhsl";
            this.btnTinhsl.Size = new System.Drawing.Size(191, 42);
            this.btnTinhsl.TabIndex = 2;
            this.btnTinhsl.Text = "Tính số lượng sinh viên";
            this.btnTinhsl.UseVisualStyleBackColor = true;
            this.btnTinhsl.Click += new System.EventHandler(this.btnTinhsl_Click);
            // 
            // Bai1_2_TruyvanCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 148);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.btnTinhsl);
            this.Name = "Bai1_2_TruyvanCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Truy vấn CSDL 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKetqua;
        private System.Windows.Forms.Button btnTinhsl;
    }
}