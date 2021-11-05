using System;
using System.Windows.Forms;
using SMD_Water_Station.Frontend;
using SMD_Water_Station.Helpers;
namespace SMD_Water_Station
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
            Application.Run(FormHandler.signIn);
        }
    }
}
