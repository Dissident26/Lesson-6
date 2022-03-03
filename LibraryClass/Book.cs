using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    public class Book
    {
        string name, library;
        int pages;

        public Book(string name, string library, int pages)
        {
            this.name = name;
            this.library = library; 
            this.pages = pages; 
        }

        public int getPages()
        {
            return pages;
        }

        public string getName()
        {
            return name; 
        }

        public string getLibrary()
        {
            return library; 
        }
    }
}
