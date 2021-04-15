using System;
using System.Windows.Forms;

namespace PRN292_Lab5_More
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
            Application.Run(new Ex1_2_FastFood());
        }
    }
}
