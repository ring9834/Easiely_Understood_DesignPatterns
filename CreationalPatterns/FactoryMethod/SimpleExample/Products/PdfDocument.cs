using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample.Products
{
    // Step 2: Create Concrete Products
    // These are the actual implementations of the product interface
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF document...");
            Console.WriteLine("Showing PDF toolbar and viewer");
        }

        public void Save()
        {
            Console.WriteLine("Saving PDF document with compression...");
        }

        public string GetDocumentType()
        {
            return "PDF Document";
        }
    }
}
