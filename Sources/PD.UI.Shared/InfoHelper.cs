using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PD.UI.Shared
{
    public static class InfoHelper {


        private static Assembly Assembly = Assembly.GetExecutingAssembly();
        public static readonly string Version = Assembly.GetName().Version.ToString();
        public static readonly string Product = GetAssemblyAttribute<AssemblyProductAttribute>(Assembly)?.Product;
        public static readonly string Company = GetAssemblyAttribute<AssemblyCompanyAttribute>(Assembly)?.Company;
        public static readonly string NameVersion =  $"{InfoHelper.Product} {InfoHelper.Version}";
        private static T GetAssemblyAttribute<T>(Assembly a) => a.GetCustomAttributes(typeof(T), false).OfType<T>().FirstOrDefault();

        public static readonly string License =
                "The MIT License (MIT)\r\n\r\n"
                +"Copyright " + (char)0169 + " " + DateTime.Now.Year + " " + Company+
                "\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy\r\n"
                + "of this software and associated documentation files(the ''Software''), to deal\r\n"
                + "in the Software without restriction, including without limitation the rights\r\n"
                + "to use, copy, modify, merge, publish, distribute, sublicense, and / or sell\r\n"
                + "copies of the Software, and to permit persons to whom the Software is\r\n"
                +"furnished to do so, subject to the following conditions:\r\n\r\n"
                + "The above copyright notice and this permission notice shall be included in all\r\n"
                + "copies or substantial portions of the Software.\r\n\r\n"
                + "THE SOFTWARE IS PROVIDED ''AS IS'', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\n"
                + "IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\n"
                + "FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE\r\n"
                + "AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\n"
                + "LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\n"
                + "OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\n"
                + "SOFTWARE.";

        public static void ShowLicense() => MessageBox.Show(License, "LICENSE", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }
}
