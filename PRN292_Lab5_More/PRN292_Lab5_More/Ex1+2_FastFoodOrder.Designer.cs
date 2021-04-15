
namespace PRN292_Lab5_More
{
    partial class Ex1_2_FastFood
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
            this.dtgrOrder = new System.Windows.Forms.DataGridView();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnKhoaiTay = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btn7Up = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnComGa = new System.Windows.Forms.Button();
            this.btnGaRan = new System.Windows.Forms.Button();
            this.cbbTableName = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGaCola = new System.Windows.Forms.Button();
            this.btnTomCola = new System.Windows.Forms.Button();
            this.btnBurgerCa = new System.Windows.Forms.Button();
            this.btnBurgerGa = new System.Windows.Forms.Button();
            this.btnBurgerBo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBurgerTom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrOrder
            // 
            this.dtgrOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrOrder.Location = new System.Drawing.Point(23, 346);
            this.dtgrOrder.Name = "dtgrOrder";
            this.dtgrOrder.Size = new System.Drawing.Size(447, 150);
            this.dtgrOrder.TabIndex = 19;
            this.dtgrOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrOrder_CellEndEdit);
            // 
            // picBox
            // 
            this.picBox.Image = global::PRN292_Lab5_More.Properties.Resources.fastfood;
            this.picBox.Location = new System.Drawing.Point(23, 18);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(103, 95);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            // 
            // btnKhoaiTay
            // 
            this.btnKhoaiTay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoaiTay.ForeColor = System.Drawing.Color.Green;
            this.btnKhoaiTay.Location = new System.Drawing.Point(319, 108);
            this.btnKhoaiTay.Name = "btnKhoaiTay";
            this.btnKhoaiTay.Size = new System.Drawing.Size(131, 24);
            this.btnKhoaiTay.TabIndex = 14;
            this.btnKhoaiTay.Text = "Khoai tây chiên";
            this.btnKhoaiTay.UseVisualStyleBackColor = true;
            this.btnKhoaiTay.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCam
            // 
            this.btnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCam.ForeColor = System.Drawing.Color.Red;
            this.btnCam.Location = new System.Drawing.Point(392, 78);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(58, 24);
            this.btnCam.TabIndex = 13;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafe.ForeColor = System.Drawing.Color.Red;
            this.btnCafe.Location = new System.Drawing.Point(317, 78);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(69, 24);
            this.btnCafe.TabIndex = 12;
            this.btnCafe.Text = "Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btn7Up
            // 
            this.btn7Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Up.ForeColor = System.Drawing.Color.Red;
            this.btn7Up.Location = new System.Drawing.Point(317, 49);
            this.btn7Up.Name = "btn7Up";
            this.btn7Up.Size = new System.Drawing.Size(69, 24);
            this.btn7Up.TabIndex = 11;
            this.btn7Up.Text = "7 Up";
            this.btn7Up.UseVisualStyleBackColor = true;
            this.btn7Up.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnLipton
            // 
            this.btnLipton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLipton.ForeColor = System.Drawing.Color.Red;
            this.btnLipton.Location = new System.Drawing.Point(392, 49);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(58, 24);
            this.btnLipton.TabIndex = 10;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            this.btnLipton.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnCoca
            // 
            this.btnCoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoca.ForeColor = System.Drawing.Color.Red;
            this.btnCoca.Location = new System.Drawing.Point(392, 19);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(58, 24);
            this.btnCoca.TabIndex = 9;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPepsi.ForeColor = System.Drawing.Color.Red;
            this.btnPepsi.Location = new System.Drawing.Point(317, 19);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(69, 24);
            this.btnPepsi.TabIndex = 8;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnComGa
            // 
            this.btnComGa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComGa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnComGa.Location = new System.Drawing.Point(168, 108);
            this.btnComGa.Name = "btnComGa";
            this.btnComGa.Size = new System.Drawing.Size(145, 24);
            this.btnComGa.TabIndex = 7;
            this.btnComGa.Text = "Cơm gà Tender";
            this.btnComGa.UseVisualStyleBackColor = true;
            this.btnComGa.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnGaRan
            // 
            this.btnGaRan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaRan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGaRan.Location = new System.Drawing.Point(168, 78);
            this.btnGaRan.Name = "btnGaRan";
            this.btnGaRan.Size = new System.Drawing.Size(145, 24);
            this.btnGaRan.TabIndex = 6;
            this.btnGaRan.Text = "Gà rán phần";
            this.btnGaRan.UseVisualStyleBackColor = true;
            this.btnGaRan.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // cbbTableName
            // 
            this.cbbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTableName.FormattingEnabled = true;
            this.cbbTableName.Location = new System.Drawing.Point(191, 301);
            this.cbbTableName.Name = "cbbTableName";
            this.cbbTableName.Size = new System.Drawing.Size(179, 24);
            this.cbbTableName.TabIndex = 18;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(387, 301);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(23, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGaCola
            // 
            this.btnGaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaCola.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGaCola.Location = new System.Drawing.Point(168, 49);
            this.btnGaCola.Name = "btnGaCola";
            this.btnGaCola.Size = new System.Drawing.Size(145, 24);
            this.btnGaCola.TabIndex = 5;
            this.btnGaCola.Text = "Gà viên Cola";
            this.btnGaCola.UseVisualStyleBackColor = true;
            this.btnGaCola.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnTomCola
            // 
            this.btnTomCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomCola.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTomCola.Location = new System.Drawing.Point(168, 19);
            this.btnTomCola.Name = "btnTomCola";
            this.btnTomCola.Size = new System.Drawing.Size(145, 24);
            this.btnTomCola.TabIndex = 4;
            this.btnTomCola.Text = "Tôm viên Cola";
            this.btnTomCola.UseVisualStyleBackColor = true;
            this.btnTomCola.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnBurgerCa
            // 
            this.btnBurgerCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerCa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerCa.Location = new System.Drawing.Point(17, 108);
            this.btnBurgerCa.Name = "btnBurgerCa";
            this.btnBurgerCa.Size = new System.Drawing.Size(145, 24);
            this.btnBurgerCa.TabIndex = 3;
            this.btnBurgerCa.Text = "Burger Phô mai Cá";
            this.btnBurgerCa.UseVisualStyleBackColor = true;
            this.btnBurgerCa.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnBurgerGa
            // 
            this.btnBurgerGa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerGa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerGa.Location = new System.Drawing.Point(17, 49);
            this.btnBurgerGa.Name = "btnBurgerGa";
            this.btnBurgerGa.Size = new System.Drawing.Size(145, 24);
            this.btnBurgerGa.TabIndex = 1;
            this.btnBurgerGa.Text = "Burger Phô mai Gà";
            this.btnBurgerGa.UseVisualStyleBackColor = true;
            this.btnBurgerGa.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnBurgerBo
            // 
            this.btnBurgerBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerBo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerBo.Location = new System.Drawing.Point(17, 19);
            this.btnBurgerBo.Name = "btnBurgerBo";
            this.btnBurgerBo.Size = new System.Drawing.Size(145, 24);
            this.btnBurgerBo.TabIndex = 0;
            this.btnBurgerBo.Text = "Burger Phô mai Bò";
            this.btnBurgerBo.UseVisualStyleBackColor = true;
            this.btnBurgerBo.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên bàn :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhoaiTay);
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnCafe);
            this.groupBox1.Controls.Add(this.btn7Up);
            this.groupBox1.Controls.Add(this.btnLipton);
            this.groupBox1.Controls.Add(this.btnCoca);
            this.groupBox1.Controls.Add(this.btnPepsi);
            this.groupBox1.Controls.Add(this.btnComGa);
            this.groupBox1.Controls.Add(this.btnGaRan);
            this.groupBox1.Controls.Add(this.btnGaCola);
            this.groupBox1.Controls.Add(this.btnTomCola);
            this.groupBox1.Controls.Add(this.btnBurgerCa);
            this.groupBox1.Controls.Add(this.btnBurgerTom);
            this.groupBox1.Controls.Add(this.btnBurgerGa);
            this.groupBox1.Controls.Add(this.btnBurgerBo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 144);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // btnBurgerTom
            // 
            this.btnBurgerTom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgerTom.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerTom.Location = new System.Drawing.Point(17, 78);
            this.btnBurgerTom.Name = "btnBurgerTom";
            this.btnBurgerTom.Size = new System.Drawing.Size(145, 24);
            this.btnBurgerTom.TabIndex = 2;
            this.btnBurgerTom.Text = "Burger Phô mai Tôm";
            this.btnBurgerTom.UseVisualStyleBackColor = true;
            this.btnBurgerTom.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(145, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fast Food Order";
            // 
            // Ex1_2_FastFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 514);
            this.Controls.Add(this.dtgrOrder);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.cbbTableName);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ex1_2_FastFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Order Application";
            this.Load += new System.EventHandler(this.Ex1_2_FastFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrOrder;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnKhoaiTay;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btn7Up;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnComGa;
        private System.Windows.Forms.Button btnGaRan;
        private System.Windows.Forms.ComboBox cbbTableName;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGaCola;
        private System.Windows.Forms.Button btnTomCola;
        private System.Windows.Forms.Button btnBurgerCa;
        private System.Windows.Forms.Button btnBurgerGa;
        private System.Windows.Forms.Button btnBurgerBo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBurgerTom;
        private System.Windows.Forms.Label label1;
    }
}