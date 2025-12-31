using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample.Products
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel document...");
            Console.WriteLine("Showing spreadsheet grid and formulas");
        }

        public void Save()
        {
            Console.WriteLine("Saving Excel document with formulas intact...");
        }

        public string GetDocumentType()
        {
            return "Excel Spreadsheet";
        }
    }
}
