using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Chapter1
{
    public class HelloWorldMirroredMarginsTop
    {
        public static void CreatePdf(string fileName)
        {
            Document document = new Document();
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            PdfWriter.GetInstance(document, stream);            
            document.SetPageSize(PageSize.A5);            
            document.SetMargins(36, 72, 108, 180);
            document.SetMarginMirroringTopBottom(true);
            document.Open();
            document.Add(new Paragraph("Hello World"));
            document.Close();
        }
    }
}
