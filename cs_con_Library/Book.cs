﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Library
{
    internal class Book
    {
        public int bId;
        public string bName;
        public int bCount;
        public int bPrice;
        public int x;

        static List<Borrower> borrowers = new List<Borrower>();
        static List<Book> bookList = new List<Book>()
        {
            new Book{bId = 1, bName = "Advanced Java",bPrice= 100},
            new Book{bId = 2, bName = "Head First C#",bPrice= 200},
            new Book{bId = 3, bName = "SQL",bPrice= 300},
            new Book{bId = 4, bName = "Math",bPrice= 400},
            new Book{bId = 5, bName = "Science",bPrice= 500},
            new Book{bId = 6, bName = "Concrete Technology",bPrice= 350}
        };
     

        public static void GetBook()
        {
            Book book = new Book();
            Console.WriteLine("Book Id:{0}", book.bId = bookList.Count + 1);
            Console.Write("Book Name:");
            book.bName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bCount = int.Parse(Console.ReadLine());
            bookList.Add(book);

            Console.WriteLine("Book Added successfully");
        }
        public static void RemoveBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter book id to be deleted:");

            int del = int.Parse(Console.ReadLine());
            if (bookList.Exists(x => x.bId == del))
            {
                bookList.RemoveAt(del - 1);
                Console.WriteLine("Book id {0} has been deleted", del);
            }
            else
            {
                Console.WriteLine("Invalid Book Id");
            }
            bookList.Add(book);
        }
        public static void SearchBook()
        {
            Book book = new Book();
            Console.Write("Search book by id:");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bId == find)
                    {
                        Console.WriteLine("Book id:{0}\nBook name:{1}\nBook Price:{2}\nBook count:{3}", searchId.bId, searchId.bName, searchId.bPrice, searchId.bCount);

                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        public static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter Folowing Details:");

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
                        Console.WriteLine("Count exist the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book Id {0} not found", returnId);
            }
        }
        public static void Display()
        {
            foreach(Book b in bookList)
            {
                Console.Write("Book id:");
                Console.WriteLine(b.bId);
                Console.Write("Book price:");
                Console.WriteLine(b.bPrice);
                Console.Write("Book Name:");
                Console.WriteLine(b.bName);
            }
            //Console.WriteLine(b);
        }

        public static void IssueBook()
        {
            Book book = new Book();
            Console.WriteLine("List of Issued book");
            //book.bId = 1;
            //book.bName = "Advanced Java";
            bookList.Add(new Book (){bId= 1,bName="Advanced Java",bPrice=100});
            bookList.Add(new Book() { bId = 2, bName = "Head First C#", bPrice = 200 });

            foreach (Book b in bookList)
            {
                Console.Write("Issued Book Id:");
                Console.WriteLine(b.bId);
                Console.Write("Issued Book Name:");
                Console.WriteLine(b.bName);

            }

        }
    }

}
