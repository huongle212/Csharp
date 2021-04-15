using PRN292_Project.view;
using System;
using System.Windows.Forms;

namespace PRN292_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Load());
            Application.Run(new FrmHome());
        }
    }
}
