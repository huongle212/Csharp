
namespace PRN292_W8_DemoCSDL
{
    partial class Bai1_1_KetnoiCSDL
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
            this.btnXemttlop = new System.Windows.Forms.Button();
            this.btnDsLop = new System.Windows.Forms.Button();
            this.btnQuanlySv = new System.Windows.Forms.Button();
            this.btnTinhSLSV = new System.Windows.Forms.Button();
            this.btn_CloseConnect = new System.Windows.Forms.Button();
            this.btn_OpenConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemttlop
            // 
            this.btnXemttlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemttlop.Location = new System.Drawing.Point(75, 151);
            this.btnXemttlop.Name = "btnXemttlop";
            this.btnXemttlop.Size = new System.Drawing.Size(226, 45);
            this.btnXemttlop.TabIndex = 11;
            this.btnXemttlop.Text = "Xem thông tin lớp";
            this.btnXemttlop.UseVisualStyleBackColor = true;
            this.btnXemttlop.Click += new System.EventHandler(this.btnXemttlop_Click);
            // 
            // btnDsLop
            // 
            this.btnDsLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDsLop.Location = new System.Drawing.Point(75, 209);
            this.btnDsLop.Name = "btnDsLop";
            this.btnDsLop.Size = new System.Drawing.Size(226, 45);
            this.btnDsLop.TabIndex = 10;
            this.btnDsLop.Text = "Danh sách lớp";
            this.btnDsLop.UseVisualStyleBackColor = true;
            this.btnDsLop.MouseCaptureChanged += new System.EventHandler(this.btnDsLop_Click);
            // 
            // btnQuanlySv
            // 
            this.btnQuanlySv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlySv.Location = new System.Drawing.Point(75, 268);
            this.btnQuanlySv.Name = "btnQuanlySv";
            this.btnQuanlySv.Size = new System.Drawing.Size(226, 45);
            this.btnQuanlySv.TabIndex = 9;
            this.btnQuanlySv.Text = "Quản lý sinh viên";
            this.btnQuanlySv.UseVisualStyleBackColor = true;
            this.btnQuanlySv.Click += new System.EventHandler(this.btnQuanlySv_Click);
            // 
            // btnTinhSLSV
            // 
            this.btnTinhSLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhSLSV.Location = new System.Drawing.Point(75, 91);
            this.btnTinhSLSV.Name = "btnTinhSLSV";
            this.btnTinhSLSV.Size = new System.Drawing.Size(226, 45);
            this.btnTinhSLSV.TabIndex = 8;
            this.btnTinhSLSV.Text = "Tính số lượng sinh viên";
            this.btnTinhSLSV.UseVisualStyleBackColor = true;
            this.btnTinhSLSV.Click += new System.EventHandler(this.btnTinhSLSV_Click);
            // 
            // btn_CloseConnect
            // 
            this.btn_CloseConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseConnect.Location = new System.Drawing.Point(75, 325);
            this.btn_CloseConnect.Name = "btn_CloseConnect";
            this.btn_CloseConnect.Size = new System.Drawing.Size(226, 45);
            this.btn_CloseConnect.TabIndex = 7;
            this.btn_CloseConnect.Text = "Đóng kết nối CSDL";
            this.btn_CloseConnect.UseVisualStyleBackColor = true;
            this.btn_CloseConnect.Click += new System.EventHandler(this.btn_CloseConnect_Click);
            // 
            // btn_OpenConnect
            // 
            this.btn_OpenConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenConnect.Location = new System.Drawing.Point(75, 32);
            this.btn_OpenConnect.Name = "btn_OpenConnect";
            this.btn_OpenConnect.Size = new System.Drawing.Size(226, 45);
            this.btn_OpenConnect.TabIndex = 6;
            this.btn_OpenConnect.Text = "Kết nối CSDL";
            this.btn_OpenConnect.UseVisualStyleBackColor = true;
            this.btn_OpenConnect.Click += new System.EventHandler(this.btn_OpenConnect_Click);
            // 
            // Bai1_1_KetnoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 398);
            this.Controls.Add(this.btnXemttlop);
            this.Controls.Add(this.btnDsLop);
            this.Controls.Add(this.btnQuanlySv);
            this.Controls.Add(this.btnTinhSLSV);
            this.Controls.Add(this.btn_CloseConnect);
            this.Controls.Add(this.btn_OpenConnect);
            this.Name = "Bai1_1_KetnoiCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Kết nối CSDL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemttlop;
        private System.Windows.Forms.Button btnDsLop;
        private System.Windows.Forms.Button btnQuanlySv;
        private System.Windows.Forms.Button btnTinhSLSV;
        private System.Windows.Forms.Button btn_CloseConnect;
        private System.Windows.Forms.Button btn_OpenConnect;
    }
}

