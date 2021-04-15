using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Lab5_More
{
    public partial class Ex1_2_FastFood : Form
    {
        private DataTable tbOrder = new DataTable("Oder menu");

        public Ex1_2_FastFood()
        {
            InitializeComponent();
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Ex1_2_FastFood_Load(object sender, EventArgs e)
        {
            var keys = new DataColumn[1];
            DataColumn column;

            // Set primary key
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "FoodName";
            keys[0] = column;
            tbOrder.Columns.Add(column);
            tbOrder.PrimaryKey = keys;

            tbOrder.Columns.Add("Quantity");
            dtgrOrder.DataSource = tbOrder;
            dtgrOrder.Columns[0].HeaderText = "Món ăn";
            dtgrOrder.Columns[1].HeaderText = "Số lượng";
            dtgrOrder.CellEndEdit += new DataGridViewCellEventHandler(dtgrOrder_CellEndEdit);
            cbbTableName.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

        }

        private void dtgrOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dtgrOrder.SelectedCells;
            if (cells.Count == 1)
            {
                try
                {
                    string val = cells[0].Value as string;
                    int.Parse(val);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dtgrOrder.CancelEdit();
                }
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (tbOrder.Rows.Contains(btn.Text))
            {
                tbOrder.Rows.Find(btn.Text)["Quantity"] = int.Parse(tbOrder.Rows.Find(btn.Text)["Quantity"].ToString()) + 1;
            }
            else
            {
                DataRow r = tbOrder.NewRow();//tạo dòng mới
                                             // thiết lập cột FoodName với món ăn được chọn
                r["FoodName"] = btn.Text;
                r["Quantity"] = 1; // thiết lập cột Quantity
                tbOrder.Rows.Add(r); // thêm vào bảng
                dtgrOrder.AutoResizeColumns();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            String tblName = cbbTableName.Text;
            if (tblName.Length == 0)
            {
                MessageBox.Show("Chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbTableName.Focus();
                return;
            }
            if (dtgrOrder == null || dtgrOrder.Rows.Count < 2)
            {
                MessageBox.Show("Chưa chọn món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã order!");
                tbOrder.Clear();   
            }
        }

        private void itemDelete(DataGridViewRow row)
        {
            string msg = $"Bạn có muốn xóa {row.Cells[1].Value}x{row.Cells[0].Value}.";

            DialogResult dialogResult = MessageBox.Show(msg, "Bạn có đồng ý xóa?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dtgrOrder.Rows.Remove(row);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgrOrder.SelectedRows)
            {
                itemDelete(row);
            }

            foreach (DataGridViewCell cell in dtgrOrder.SelectedCells)
            {
                itemDelete(cell.OwningRow);
            }
        }
    }
}
