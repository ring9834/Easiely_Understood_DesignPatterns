using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample.Products
{
    // Step 1: Create the Product Interface
    // This defines the interface for objects the factory method creates
    public interface IDocument
    {
        void Open();
        void Save();
        string GetDocumentType();
    }
}
