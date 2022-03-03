using LibraryClass;
using Extensions;

Library firstLibrary = new Library();

firstLibrary.Books = new Book[10]
{
    new Book("#1", "First Library", 23),
    new Book("#2", "Second Library", 32),
    new Book("#3", "First Library", 12),
    new Book("#4", "Third Library", 65),
    new Book("#5", "First Library", 87),
    new Book("#6", "Second Library", 53),
    new Book("#7", "Second Library", 92),
    new Book("#8", "Third Library", 15),
    new Book("#9", "Third Library", 61),
    new Book("#10", "Fourth Library", 22),
};

Book bookWithIndex1 = firstLibrary.getBookByIndex(1);
Book bookWithIndex3 = firstLibrary.getBookByIndex(3);
Book bookWithIndex9 = firstLibrary.getBookByIndex(9);
showBookInfo(bookWithIndex1);
showBookInfo(bookWithIndex3);
showBookInfo(bookWithIndex9);


searchBookByName(firstLibrary);
searchBookWithMaxPages(firstLibrary);

//bubble sort
int[] unsortedArray = new int[10] { 5, 3, 1, 7, 4, 2, 9, 8, 6, 10 };
int[] sortedArray = unsortedArray.bubbleSort();

void showBookInfo(Book book)
{
    Console.WriteLine("Название: '{0}''", book.getName());
    Console.WriteLine("Количество страниц: {0}", book.getPages());
    Console.WriteLine("Книга находится в {0}", book.getLibrary());
}

void searchBookByName(Library library)
{
    Console.WriteLine("ВВедите имя книги: ");
    string name = Console.ReadLine();
    Book? book = library.getByName(name);

    if(book == null)
    {
        Console.WriteLine("Такой книги нет ни в одной библиотеке!");
    }

    showBookInfo(book);
}

void searchBookWithMaxPages(Library library)
{
    Console.WriteLine("самая 'толстая' книга: ");
    Book book = library.Books.getBookWithMaxPages();
    showBookInfo(book);
}