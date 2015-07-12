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
    public class HelloWorldColumn
    {
        public static void CreatePdf(string fileName)
        {
            Document document = new Document();
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.Open();            
            writer.CompressionLevel = 0;
            Phrase hello = new Phrase("Hello World");
            PdfContentByte canvas = writer.DirectContentUnder;
            ColumnText.ShowTextAligned(canvas, Element.ALIGN_LEFT, hello, 36, 788, 0);
            document.Close();
        }
    }
}
