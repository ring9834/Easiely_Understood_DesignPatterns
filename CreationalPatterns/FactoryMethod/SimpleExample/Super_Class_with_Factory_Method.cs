using SimpleExample.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    // Step 3: Create the Creator Abstract Class
    // This declares the factory method that returns an IDocument
    public abstract class DocumentCreator
    {
        // The factory method - subclasses will override this
        public abstract IDocument CreateDocument();

        // Some operation that uses the product
        public void ProcessDocument()
        {
            // Call the factory method to create a product
            IDocument document = CreateDocument();

            Console.WriteLine($"\nProcessing {document.GetDocumentType()}:");
            document.Open();
            document.Save();
            Console.WriteLine($"Finished processing {document.GetDocumentType()}\n");
        }

        // Another common use: the creator can work with the product
        public string GetDocumentInfo()
        {
            IDocument document = CreateDocument();
            return $"Document Type: {document.GetDocumentType()}";
        }
    }
}
