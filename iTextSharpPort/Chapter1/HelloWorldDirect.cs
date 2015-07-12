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
    public class HelloWorldDirect
    {
        public static void CreatePdf(string fileName)
        {
            Document document = new Document();
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfContentByte canvas = writer.DirectContentUnder;
            writer.CompressionLevel = 0;
            canvas.SaveState();  // q
            canvas.BeginText();  // BT
            canvas.MoveText(36, 788);  // 36 788 Td
            canvas.SetFontAndSize(BaseFont.CreateFont(), 12); // /F1 12 Tf
            canvas.ShowText("Hello World"); // (Hello World)Tj
            canvas.EndText(); // ET
            canvas.RestoreState(); // Q
            document.Close();
        }
    }
}
