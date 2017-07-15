using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using EMSV.CL.UI.UI;

namespace EMSV.CL.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LanguageManager.Get();
            Application.Run(new FrmMain());
        }
    }

    public static class LanguageManager
    {

        private static readonly string Mothafuckinglocale = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "mothafuckinglocale");

        public static void Get()
        {
            var c = File.Exists(Mothafuckinglocale) ? CultureInfo.GetCultureInfo(File.ReadAllText(Mothafuckinglocale)) : CultureInfo.CurrentUICulture;
            var thread = Thread.CurrentThread;
            thread.CurrentCulture = thread.CurrentUICulture = c;
        }

        public static void Set(string s)
        {
            File.WriteAllText(Mothafuckinglocale, s);
            Get();
            Application.Restart();
        }
    }
}
