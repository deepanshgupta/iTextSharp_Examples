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
    public class HelloWorldMaximum
    {
        public static void CreatePdf(string fileName)
        {
            Document document = new Document(new Rectangle(14400, 14400));
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            writer.Userunit = 75000f;
            document.Open();
            document.Add(new Paragraph("Hello World"));
            document.Close();
        }
    }
}
