namespace PastryShopProductManagementSystem.Frames.Helpers
{
    using DocumentTemplate;
    using RazorEngine.Templating;
    using SelectPdf;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;

    public class PdfMaker
    {
        public void CreatePdfDocumet(DocumentModel docModel)
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            var templatePath = path + @"\DocumentTemplate\Document.cshtml";
            string template = File.ReadAllText(templatePath);
            TemplateService templateParser = new TemplateService();
            string htmlAsString = templateParser.Parse(template, docModel, null, "key");

            HtmlToPdf converter = new HtmlToPdf();
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
            converter.Options.MarginBottom = 10;
            converter.Options.MarginTop = 10;
            converter.Options.MarginLeft = 10;
            converter.Options.MarginRight = 10;
            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.KeepTextsTogether = true;

            PdfDocument doc = converter.ConvertHtmlString(htmlAsString);
            SaveFileDialog dl = new SaveFileDialog();
            dl.Filter = "PDF|*.pdf";
            dl.ShowDialog();
            string documentPath = dl.FileName;
            //string docModelDate = docModel.IssueDate.ToShortDateString().Replace('/', '_');
            //documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + docModelDate + ".pdf";
            doc.Save(documentPath);
            doc.Close();
            Process.Start(documentPath);
        }
    }
}
