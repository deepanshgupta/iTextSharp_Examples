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
    public class HelloWorldVersion_1_7
    {
        public static void CreatePdf(string fileName)
        {
            Document document = new Document();
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_7);
            document.Open();
            document.Add(new Paragraph("Hello World"));
            document.Close();
        }
    }
}
