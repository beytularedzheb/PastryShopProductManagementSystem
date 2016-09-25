using PastryShopProductManagementSystem.Data;
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

            PastryShopData db = new PastryShopData(new PastryShopDbContext());

            var templatePath = @"C:\Users\Vasko\Source\Repos\PastryShopProductManagementSystem\PastryShopProductManagementSystem\DocumentTemplate\Document.cshtml";
            var model = new Provider { Name = "ivan" };
            var text = File.ReadAllText(templatePath);

            var result =
                Engine.Razor.RunCompile(text, "templateKey", null,model);
            
            HtmlToPdf converter = new HtmlToPdf();

            // create a new pdf document converting the html string of the page
            PdfDocument doc = converter.ConvertHtmlString(
                result);

            // save pdf document
            doc.Save("Sample.pdf");

            // close pdf document
            doc.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}
