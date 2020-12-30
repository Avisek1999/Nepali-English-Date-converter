using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Schema;

namespace NepaliDateConverter.Net
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
            Application.Run(new DateConverterApp());
        }
    }
}
