using PastryShopProductManagementSystem.Data;
using PastryShopProductManagementSystem.DocumentTemplate;
using PastryShopProductManagementSystem.Models;
using RazorEngine;
using RazorEngine.Templating;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastryShopProductManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}
