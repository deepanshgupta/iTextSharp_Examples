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
    public class HelloWorldMemory
    {
        public static void CreatePdf(string fileName)
        {
            Document document = new Document();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
            document.Open();
            document.Add(new Paragraph("Hello World"));
            writer.CloseStream = false;
            document.Close();
            memoryStream.Position = 0;
            FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            memoryStream.WriteTo(fileStream);
            fileStream.Close();
        }
    }
}
