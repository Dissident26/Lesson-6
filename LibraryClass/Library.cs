namespace LibraryClass
{
    public class Library
    {
        public Book[] Books { get; set; }

       public Book getBookByIndex(int index)
        {
            return Books[index];    
        }

        public Book? getByName(string name)
        {
            return Array.Find(Books, book => book.getName() == name);
        }
    }
}