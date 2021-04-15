
namespace Week9_Class
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label masvLabel;
            System.Windows.Forms.Label hotenLabel;
            System.Windows.Forms.Label malopLabel;
            this.pRN292_QLSinhVienDataSet = new Week9_Class.PRN292_QLSinhVienDataSet();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new Week9_Class.PRN292_QLSinhVienDataSetTableAdapters.LopTableAdapter();
            this.tableAdapterManager = new Week9_Class.PRN292_QLSinhVienDataSetTableAdapters.TableAdapterManager();
            this.lopBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lopBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lopDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new Week9_Class.PRN292_QLSinhVienDataSetTableAdapters.SinhVienTableAdapter();
            this.masvTextBox = new System.Windows.Forms.TextBox();
            this.hotenTextBox = new System.Windows.Forms.TextBox();
            this.cboMalop = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            masvLabel = new System.Windows.Forms.Label();
            hotenLabel = new System.Windows.Forms.Label();
            malopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingNavigator)).BeginInit();
            this.lopBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRN292_QLSinhVienDataSet
            // 
            this.pRN292_QLSinhVienDataSet.DataSetName = "PRN292_QLSinhVienDataSet";
            this.pRN292_QLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.pRN292_QLSinhVienDataSet;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LopTableAdapter = this.lopTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = Week9_Class.PRN292_QLSinhVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lopBindingNavigator
            // 
            this.lopBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lopBindingNavigator.BindingSource = this.lopBindingSource;
            this.lopBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lopBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lopBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lopBindingNavigatorSaveItem});
            this.lopBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lopBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lopBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lopBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lopBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lopBindingNavigator.Name = "lopBindingNavigator";
            this.lopBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lopBindingNavigator.Size = new System.Drawing.Size(816, 25);
            this.lopBindingNavigator.TabIndex = 0;
            this.lopBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lopBindingNavigatorSaveItem
            // 
            this.lopBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lopBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lopBindingNavigatorSaveItem.Image")));
            this.lopBindingNavigatorSaveItem.Name = "lopBindingNavigatorSaveItem";
            this.lopBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lopBindingNavigatorSaveItem.Text = "Save Data";
            this.lopBindingNavigatorSaveItem.Click += new System.EventHandler(this.lopBindingNavigatorSaveItem_Click);
            // 
            // lopDataGridView
            // 
            this.lopDataGridView.AutoGenerateColumns = false;
            this.lopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lopDataGridView.DataSource = this.lopBindingSource;
            this.lopDataGridView.Location = new System.Drawing.Point(24, 31);
            this.lopDataGridView.Name = "lopDataGridView";
            this.lopDataGridView.Size = new System.Drawing.Size(354, 220);
            this.lopDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Malop";
            this.dataGridViewTextBoxColumn1.HeaderText = "Malop";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tenlop";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tenlop";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.pRN292_QLSinhVienDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // masvLabel
            // 
            masvLabel.AutoSize = true;
            masvLabel.Location = new System.Drawing.Point(283, 288);
            masvLabel.Name = "masvLabel";
            masvLabel.Size = new System.Drawing.Size(36, 13);
            masvLabel.TabIndex = 3;
            masvLabel.Text = "Masv:";
            // 
            // masvTextBox
            // 
            this.masvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Masv", true));
            this.masvTextBox.Location = new System.Drawing.Point(328, 285);
            this.masvTextBox.Name = "masvTextBox";
            this.masvTextBox.Size = new System.Drawing.Size(177, 20);
            this.masvTextBox.TabIndex = 4;
            // 
            // hotenLabel
            // 
            hotenLabel.AutoSize = true;
            hotenLabel.Location = new System.Drawing.Point(283, 314);
            hotenLabel.Name = "hotenLabel";
            hotenLabel.Size = new System.Drawing.Size(39, 13);
            hotenLabel.TabIndex = 5;
            hotenLabel.Text = "Hoten:";
            // 
            // hotenTextBox
            // 
            this.hotenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Hoten", true));
            this.hotenTextBox.Location = new System.Drawing.Point(328, 311);
            this.hotenTextBox.Name = "hotenTextBox";
            this.hotenTextBox.Size = new System.Drawing.Size(177, 20);
            this.hotenTextBox.TabIndex = 6;
            // 
            // malopLabel
            // 
            malopLabel.AutoSize = true;
            malopLabel.Location = new System.Drawing.Point(283, 340);
            malopLabel.Name = "malopLabel";
            malopLabel.Size = new System.Drawing.Size(39, 13);
            malopLabel.TabIndex = 7;
            malopLabel.Text = "Malop:";
            // 
            // cboMalop
            // 
            this.cboMalop.DataSource = this.lopBindingSource;
            this.cboMalop.DisplayMember = "Tenlop";
            this.cboMalop.FormattingEnabled = true;
            this.cboMalop.Location = new System.Drawing.Point(328, 335);
            this.cboMalop.Name = "cboMalop";
            this.cboMalop.Size = new System.Drawing.Size(177, 21);
            this.cboMalop.TabIndex = 8;
            this.cboMalop.ValueMember = "Malop";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(546, 304);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "List student";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cboMalop);
            this.Controls.Add(masvLabel);
            this.Controls.Add(this.masvTextBox);
            this.Controls.Add(hotenLabel);
            this.Controls.Add(this.hotenTextBox);
            this.Controls.Add(malopLabel);
            this.Controls.Add(this.lopDataGridView);
            this.Controls.Add(this.lopBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRN292_QLSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingNavigator)).EndInit();
            this.lopBindingNavigator.ResumeLayout(false);
            this.lopBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PRN292_QLSinhVienDataSet pRN292_QLSinhVienDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private PRN292_QLSinhVienDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private PRN292_QLSinhVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lopBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton lopBindingNavigatorSaveItem;
        private PRN292_QLSinhVienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridView lopDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.TextBox masvTextBox;
        private System.Windows.Forms.TextBox hotenTextBox;
        private System.Windows.Forms.ComboBox cboMalop;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}