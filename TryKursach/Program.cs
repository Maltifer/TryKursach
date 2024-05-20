using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TryKursach
{
    internal static class Program
    {
        public static Prisoners MyPrison = new Prisoners();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnApplicationExit);
            Application.Run(new MainForm(MyPrison));
        }
        public static void OnApplicationExit(object sender, EventArgs e)
        {
            MyPrison.Save();
        }
    }
}