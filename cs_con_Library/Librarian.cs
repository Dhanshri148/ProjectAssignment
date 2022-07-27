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
        

        public static void SearchBookForBorrower()                   
        {

            Book book = new Book();
            Console.Write("Search book by id");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bId == find)
                    {
                        Console.WriteLine("Book id:{0}\nBook name:{1}\nBook Price:{2}", searchId.bId, searchId.bName, searchId.bPrice);

                    }
                    Console.WriteLine("Book Found");
                }
                
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        public static void AddBookAfterReceiving()
        {

            Book book = new Book();
            Console.WriteLine("Enter Following Details:");

            Console.Write("Book Id:");
            int returnId = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            bookList.Add(book);

            Console.WriteLine("Book received successfully");
        }
    }
}
