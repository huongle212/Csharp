using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_Lab7_More
{
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void monHocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.monHocBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pRN292_QLSV_Lab7DataSet);
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.ToString()}");
            }

        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRN292_QLSV_Lab7DataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.pRN292_QLSV_Lab7DataSet.MonHoc);

        }

        private void soTietTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
