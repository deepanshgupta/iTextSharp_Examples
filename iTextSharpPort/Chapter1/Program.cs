using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld.CreatePdf("HelloWorld.pdf");
            HelloWorldNarrow.CreatePdf("HelloWorldNarrow.pdf");
            HelloWorldMaximum.CreatePdf("HelloWorldMaximum.pdf");
            HelloWorldLetter.CreatePdf("HelloWorldLetter.pdf");
            HelloWorldLandscape1.CreatePdf("HelloWorldLandscape1.pdf");
            HelloWorldLandscape2.CreatePdf("HelloWorldLandscape2.pdf");

            HelloWorldMirroredMargins.CreatePdf("HelloWorldMirroredMargins.pdf");
            HelloWorldMirroredMarginsTop.CreatePdf("HelloWorldMirroredMarginsTop.pdf");
            HelloWorldMemory.CreatePdf("HelloWorldMemory.pdf");
            HelloWorldVersion_1_7.CreatePdf("HelloWorldVersion_1_7.pdf");
            HelloWorldDirect.CreatePdf("HelloWorldDirect.pdf");
            HelloZip.CreatePdf("HelloWorld.zip");
        }
    }
}
