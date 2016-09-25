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

            //PastryShopData db = new PastryShopData(new PastryShopDbContext());

            //var templatePath = @"C:\Users\Vasko\Source\Repos\PastryShopProductManagementSystem\PastryShopProductManagementSystem\DocumentTemplate\Document.cshtml";
            //string template = File.ReadAllText(templatePath);
            //var model = new DocumentModel();
            //model.Products = ProductInfo.GetProducts();
            //string htmlAsString = Engine.Razor.RunCompile(template, "key", typeof(DocumentModel), model);
            
            //HtmlToPdf converter = new HtmlToPdf();
            //// create a new pdf document converting the html string of the page
            //converter.Options.PdfPageOrientation = PdfPageOrientation.Landscape;
            //PdfDocument doc = converter.ConvertHtmlString(htmlAsString);
            //// save pdf document
            //doc.Save("Neww.pdf");

            //// close pdf document
            //doc.Close();
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}
