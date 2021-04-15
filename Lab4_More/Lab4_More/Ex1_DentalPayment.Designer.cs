
namespace Lab4_More
{
    partial class Ex1_DentalPayment
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
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.chkWhiten = new System.Windows.Forms.CheckBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.lblWhitenCost = new System.Windows.Forms.Label();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Location = new System.Drawing.Point(20, 186);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(98, 17);
            this.chkXRay.TabIndex = 37;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            // 
            // chkWhiten
            // 
            this.chkWhiten.AutoSize = true;
            this.chkWhiten.Location = new System.Drawing.Point(20, 141);
            this.chkWhiten.Name = "chkWhiten";
            this.chkWhiten.Size = new System.Drawing.Size(75, 17);
            this.chkWhiten.TabIndex = 36;
            this.chkWhiten.Text = "Tẩy Trắng";
            this.chkWhiten.UseVisualStyleBackColor = true;
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Location = new System.Drawing.Point(20, 103);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(62, 17);
            this.chkClean.TabIndex = 35;
            this.chkClean.Text = "Cạo vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Location = new System.Drawing.Point(222, 230);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(85, 13);
            this.lblFillCost.TabIndex = 34;
            this.lblFillCost.Text = "80.000 VND/cái";
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(94, 223);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(81, 20);
            this.numFilling.TabIndex = 33;
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(199, 327);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 32;
            this.btnCal.Text = "Tính tiền";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(57, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(187, 263);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 30;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(127, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 29;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(111, 266);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Location = new System.Drawing.Point(25, 225);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(55, 13);
            this.lblFilling.TabIndex = 27;
            this.lblFilling.Text = "Trám răng";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Location = new System.Drawing.Point(222, 186);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(72, 13);
            this.lblXRayCost.TabIndex = 26;
            this.lblXRayCost.Text = "200.000 VND";
            // 
            // lblWhitenCost
            // 
            this.lblWhitenCost.AutoSize = true;
            this.lblWhitenCost.Location = new System.Drawing.Point(213, 141);
            this.lblWhitenCost.Name = "lblWhitenCost";
            this.lblWhitenCost.Size = new System.Drawing.Size(81, 13);
            this.lblWhitenCost.TabIndex = 25;
            this.lblWhitenCost.Text = "1.200.000 VND";
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Location = new System.Drawing.Point(222, 104);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(72, 13);
            this.lblCleanCost.TabIndex = 24;
            this.lblCleanCost.Text = "100.000 VND";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 16);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Tên khách hàng";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(52, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 29);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Dental Payment Form";
            // 
            // Ex1_DentalPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 372);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.chkWhiten);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFilling);
            this.Controls.Add(this.lblXRayCost);
            this.Controls.Add(this.lblWhitenCost);
            this.Controls.Add(this.lblCleanCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Ex1_DentalPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Payment Form";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkXRay;
        private System.Windows.Forms.CheckBox chkWhiten;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.Label lblXRayCost;
        private System.Windows.Forms.Label lblWhitenCost;
        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
    }
}

