using System;
using System.Windows.Forms;

namespace PRN292_Lab3M_2_GcdLcm
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
            Application.Run(new GcdLcm());
        }
    }
}
