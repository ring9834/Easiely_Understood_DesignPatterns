using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample.Products
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word document...");
            Console.WriteLine("Showing text formatting toolbar");
        }

        public void Save()
        {
            Console.WriteLine("Saving Word document with .docx format...");
        }

        public string GetDocumentType()
        {
            return "Word Document";
        }
    }
}
