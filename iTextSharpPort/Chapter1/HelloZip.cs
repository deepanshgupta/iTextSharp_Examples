using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ICSharpCode.SharpZipLib.Zip;

namespace Chapter1
{
    public class HelloZip
    {
        public static void CreatePdf(string fileName)
        {
            using (ZipOutputStream zipStream = new ZipOutputStream(File.Create(fileName)))
            {
                for (int counter = 1; counter <= 3; counter++)
                {
                    ZipEntry entry = new ZipEntry("hello" + counter + ".pdf");
                    zipStream.PutNextEntry(entry);
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, zipStream);
                    writer.CloseStream = false;
                    document.Open();
                    document.Add(new Paragraph("Hello " + counter));
                    document.Close();
                    zipStream.CloseEntry();
                }
                zipStream.Finish();
                zipStream.Close();
            }
        }
    }
}
