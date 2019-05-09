using DevExpress.UserSkins;
using GiaoDien.Views;
using System;
using System.Windows.Forms;

namespace GiaoDien
{
    static class Program
    {
        public static frmMain mainForm = null;
        public static frmDagNhap frmDN = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDN = new frmDagNhap();
            Application.Run(frmDN);
        }
    }
}
