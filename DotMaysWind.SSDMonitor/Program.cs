using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace DotMaysWind.SSDMonitor
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                String lang = ConfigurationManager.AppSettings["lang"];

                if (!String.IsNullOrWhiteSpace(lang) && !String.Equals(lang, "auto", StringComparison.OrdinalIgnoreCase) && CultureInfo.GetCultureInfo(lang) != null)
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
                }
            }
            catch (CultureNotFoundException) { }
            finally
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}