using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Library
{
    internal class Librarian
    {

        public int librarianId;
        public string userName;
        public string password;
        public int issueBookId;
        public int issuedCount;
        public DateTime issueDate;

        static List<Book> bookList = new List<Book>();
        public static void IssueBook()
        {
            Book book = new Book();
            Console.WriteLine("List of Issued book");
            bookList.Add(book);
           
        }

        public static void GetBookFromBorrower()
        {

        }

        public static void SearchBookForBorrower()
        {
            Book book = new Book();
            Console.WriteLine("Search book by id");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bId == find)
                    {
                        Console.WriteLine("Book id:{0}\nBook name:{1}\nBook Price:{2} \n Book count{3}", searchId.bId, searchId.bName, searchId.bPrice, searchId.bCount);

                    }
                }
            }
        }

        public static void AddBookAfterReceiving()
        {

            Book book = new Book();
            Console.WriteLine("Enter Foloowing Details:");

            Console.Write("Book Id:");
            int returnId = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bCount)
                    {
                        if (addReturnBookCount.bId == returnId)
                        {
                            addReturnBookCount.bCount = addReturnBookCount.bCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Book Id {0} not found", returnId);
                    }
                }
            }
        }
    }
}
