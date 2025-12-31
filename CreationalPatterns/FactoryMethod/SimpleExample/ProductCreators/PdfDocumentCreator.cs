using SimpleExample.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample.ProductCreators
{
    // Step 4: Create Concrete Creators
    // These override the factory method to return specific products
    public class PdfDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
