using SimpleExample.ProductCreators;
using SimpleExample.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    // Client Code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factory Method Pattern Demo ===\n");

            // Example 1: Using specific creators directly
            Console.WriteLine("1. Creating specific documents:");

            DocumentCreator pdfCreator = new PdfDocumentCreator();
            DocumentCreator wordCreator = new WordDocumentCreator();
            DocumentCreator excelCreator = new ExcelDocumentCreator();

            // Each creator creates its specific type of document
            pdfCreator.ProcessDocument();
            wordCreator.ProcessDocument();
            excelCreator.ProcessDocument();

            // Example 2: Using factory method dynamically
            Console.WriteLine("2. Creating documents based on user input:");

            // Simulating different document types based on some condition
            string[] requestedDocumentTypes = { "pdf", "word", "excel", "word", "pdf" };

            foreach (string docType in requestedDocumentTypes)
            {
                DocumentCreator creator = GetDocumentCreator(docType);
                if (creator != null)
                {
                    creator.ProcessDocument();
                }
            }

            // Example 3: Getting document info without creating full instances
            Console.WriteLine("3. Document information:");
            DocumentCreator[] creators = {
                new PdfDocumentCreator(),
                new WordDocumentCreator(),
                new ExcelDocumentCreator()
            };

            foreach (var creator in creators)
            {
                Console.WriteLine(creator.GetDocumentInfo());
            }

            // Example 4: Direct use of factory method
            Console.WriteLine("\n4. Direct factory method usage:");
            DocumentCreator directCreator = new WordDocumentCreator();
            IDocument document = directCreator.CreateDocument();
            Console.WriteLine($"Created: {document.GetDocumentType()}");
        }

        // Factory method that returns appropriate creator based on type
        static DocumentCreator GetDocumentCreator(string documentType)
        {
            return documentType.ToLower() switch
            {
                "pdf" => new PdfDocumentCreator(),
                "word" => new WordDocumentCreator(),
                "excel" => new ExcelDocumentCreator(),
                _ => null
            };
        }
    }
}
