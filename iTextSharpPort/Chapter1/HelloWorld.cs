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
    public class HelloWorld
    {
        public static void CreatePdf(string fileName)
        {
            Document document = new Document();
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            document.Add(new Paragraph("Hello World"));
            document.Close();
        }
    }
}
