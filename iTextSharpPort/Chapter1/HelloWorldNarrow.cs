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
    public class HelloWorldNarrow
    {
        public static void CreatePdf(string fileName)
        {
            Rectangle pagesize = new Rectangle(216f, 720f);
            Document document = new Document(pagesize, 36f, 72f, 108f, 180f);
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            document.Add(new Paragraph("Hello World"));
            document.Close();
        }
    }
}
