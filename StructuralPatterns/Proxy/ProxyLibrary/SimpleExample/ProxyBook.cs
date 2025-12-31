using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLibrary.SimpleExample
{
    // 3. The Proxy
    public class ProxyBook : IBook
    {
        private RealBook _realBook;
        private string _title;
        private string _password;

        public ProxyBook(string title, string password)
        {
            _title = title;
            _password = password;
        }

        public void DisplayContent()
        {
            // The Proxy adds an extra layer of logic (Security/Lazy Loading)
            if (_password == "Secret123")
            {
                if (_realBook == null)
                {
                    _realBook = new RealBook(_title);
                }
                _realBook.DisplayContent();
            }
            else
            {
                Console.WriteLine("Access Denied: Incorrect password.");
            }
        }
    }
}
