using LibraryClass;

namespace Extensions
{
    static public class Extensions
    {
        public static Book getBookWithMaxPages(this Book[] allBooks)
        {
            Book searchResult = allBooks[0];
            foreach (Book book in allBooks)
            {
                if(book.getPages() > searchResult.getPages())
                {
                    searchResult = book;
                }
            }

            return searchResult;
        }

        public static int[] bubbleSort(this int[] intArray)
        {
            int temp;
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            return intArray;
        }
    }
}