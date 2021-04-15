using System;
using System.IO;
using System.Windows.Forms;

namespace PRN292_Lab4_DB
{
    public partial class FrmMain : Form
    {
        //private stactic string strconn = global::PRN292_Lab4_DB.Properties.Settings.Default.NorthwindConnectionString;
        //private static string strconn = "Data Source=Mit;Initial Catalog=Northwind;User ID=sa;Password=sa";
        private static string strconn = "";

        public static string Strconn { get => strconn; set => strconn = value; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader file = new StreamReader("config.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        strconn += line + ";";
                    }
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories categories = new FrmCategories();
            categories.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            FrmSuppliers suppliers = new FrmSuppliers();
            suppliers.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ShowDialog();
        }
    }
}