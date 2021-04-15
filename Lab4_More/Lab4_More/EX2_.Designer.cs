
namespace Lab4_More
{
    partial class EX2_
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
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.chkWhiten = new System.Windows.Forms.CheckBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.btnCal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.lblWhitenCost = new System.Windows.Forms.Label();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lstBill = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkXRay);
            this.groupBox1.Controls.Add(this.chkWhiten);
            this.groupBox1.Controls.Add(this.chkClean);
            this.groupBox1.Controls.Add(this.lblFillCost);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.numFilling);
            this.groupBox1.Controls.Add(this.btnCal);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblFilling);
            this.groupBox1.Controls.Add(this.lblXRayCost);
            this.groupBox1.Controls.Add(this.lblWhitenCost);
            this.groupBox1.Controls.Add(this.lblCleanCost);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dental Payment Form";
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Location = new System.Drawing.Point(29, 161);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(98, 17);
            this.chkXRay.TabIndex = 53;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            this.chkXRay.CheckedChanged += new System.EventHandler(this.chkXRay_CheckedChanged);
            // 
            // chkWhiten
            // 
            this.chkWhiten.AutoSize = true;
            this.chkWhiten.Location = new System.Drawing.Point(29, 116);
            this.chkWhiten.Name = "chkWhiten";
            this.chkWhiten.Size = new System.Drawing.Size(75, 17);
            this.chkWhiten.TabIndex = 52;
            this.chkWhiten.Text = "Tẩy Trắng";
            this.chkWhiten.UseVisualStyleBackColor = true;
            this.chkWhiten.CheckedChanged += new System.EventHandler(this.chkWhiten_CheckedChanged);
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Location = new System.Drawing.Point(29, 78);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(62, 17);
            this.chkClean.TabIndex = 51;
            this.chkClean.Text = "Cạo vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            this.chkClean.CheckedChanged += new System.EventHandler(this.chkClean_CheckedChanged);
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Location = new System.Drawing.Point(231, 205);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(85, 13);
            this.lblFillCost.TabIndex = 50;
            this.lblFillCost.Text = "80.000 VND/cái";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(37, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(103, 198);
            this.numFilling.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(59, 20);
            this.numFilling.TabIndex = 49;
            this.numFilling.ValueChanged += new System.EventHandler(this.numFilling_ValueChanged);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(196, 279);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(96, 23);
            this.btnCal.TabIndex = 48;
            this.btnCal.Text = "Thanh toán";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(196, 238);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 46;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(136, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 45;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(120, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "Total";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Location = new System.Drawing.Point(34, 200);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(55, 13);
            this.lblFilling.TabIndex = 43;
            this.lblFilling.Text = "Trám răng";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Location = new System.Drawing.Point(231, 161);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(72, 13);
            this.lblXRayCost.TabIndex = 42;
            this.lblXRayCost.Text = "200.000 VND";
            // 
            // lblWhitenCost
            // 
            this.lblWhitenCost.AutoSize = true;
            this.lblWhitenCost.Location = new System.Drawing.Point(222, 116);
            this.lblWhitenCost.Name = "lblWhitenCost";
            this.lblWhitenCost.Size = new System.Drawing.Size(81, 13);
            this.lblWhitenCost.TabIndex = 41;
            this.lblWhitenCost.Text = "1.200.000 VND";
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Location = new System.Drawing.Point(231, 79);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(72, 13);
            this.lblCleanCost.TabIndex = 40;
            this.lblCleanCost.Text = "100.000 VND";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(26, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 16);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Tên khách hàng";
            // 
            // lstBill
            // 
            this.lstBill.FormattingEnabled = true;
            this.lstBill.Location = new System.Drawing.Point(385, 19);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(206, 212);
            this.lstBill.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(385, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(496, 251);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(95, 23);
            this.btnOpenFile.TabIndex = 55;
            this.btnOpenFile.Text = "Đọc file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // EX2_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 339);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstBill);
            this.Controls.Add(this.groupBox1);
            this.Name = "EX2_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dental Payment Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EX2__FormClosing);
            this.Load += new System.EventHandler(this.EX2__Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ListBox lstBill;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenFile;
    }
}