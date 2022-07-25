using System;
using System.Collections.Generic;

namespace cs_con_Library
{
    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<Borrower> borrowers = new List<Borrower>();

        static Book book = new Book();
        static Borrower borrower = new Borrower();

        static void Main(string[] args)
        {
            Console.WriteLine("Select who are you:");
            Console.WriteLine("1.Borrower\n2.Librarian\n3.Exit");

            Console.WriteLine("Enter value:");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    {
                        Console.WriteLine("Welcome in Library!!");
                        Console.Write("Enter your Password : ");
                        string password = Console.ReadLine();
                        if (password == "pass")
                        {
                            bool close = true;
                            while (close)
                            {
                                Console.WriteLine("\nMenu\n1)Borrow Book\n2)Search Book\n3)Return Book\n4)Borrow Book\n5)Display\n6)Close\n\n");
                                Console.Write("Choose Your  option from menu:");

                                int option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    Book.GetBook();
                                }

                                else if (option == 2)
                                {
                                    Book.SearchBook();
                                }

                                else if (option == 3)
                                {
                                    //Book.RemoveBook();
                                    Book.ReturnBook();
                                }
                                else if(option == 4)
                                {
                                    Borrow();
                                }
                                else if (option == 5)
                                {
                                    Book.Display();
                                }
                                else if (option == 6)
                                {
                                    Console.WriteLine("Thank You");
                                    close = false;
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Invalid Operation!!!");
                                }
                                Console.ReadLine();
                            }
                        }

                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Welcome in Library!!");
                        Console.Write("Enter your Password : ");
                        string password = Console.ReadLine();
                        bool enter = true;
                        while (enter)
                        {

                            if (password == "pass123")
                            {
                                bool close = true;
                                while (close)
                                {
                                    Console.WriteLine("\nMenu\n1)Search Book\n2)Issue Book\n3)Get Book from borrower\n4)Close\n\n");
                                    Console.WriteLine("Choose Your  option from menu:");

                                    int option = int.Parse(Console.ReadLine());

                                    if (option == 1)
                                    {
                                        Librarian.SearchBookForBorrower();
                                    }
                                    else if (option == 2)
                                    {
                                        Librarian.IssueBook();
                                    }
                                    else if (option == 3)
                                    {
                                        Librarian.AddBookAfterReceiving();
                                    }
                                    else if (option == 4)
                                    {
                                        Console.WriteLine("Thank You");
                                        close = false;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Value");
                                    }
                                    Console.ReadLine();
                                }
                            }
                        }
                    }
                    break;

                    case 3:
                    {
                        Console.WriteLine("Logout ");
                        
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;

                    
            }
        }
        public static void Borrow()
        {
              Book book = new Book();
              Borrower borrow = new Borrower();
              Console.WriteLine("User id:{0}", (borrow.userId = borrowers.Count + 1));

              Console.Write("Book Id:");
              borrow.borrowerBookId = int.Parse(Console.ReadLine());

              Console.Write("Book Name:");
              borrow.userName = Console.ReadLine();

                Console.Write("Address:");
                borrow.address = Console.ReadLine();

                borrow.borrowDate = DateTime.Now;
                Console.WriteLine("Date-{0} and Time-{1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

                if (bookList.Exists(x => x.bId == borrow.borrowerBookId))
                {
                    foreach (Book searchId in bookList)
                    {
                        if (searchId.bCount >= searchId.bCount - borrow.borrowCount && searchId.bCount - borrow.borrowCount >= 0)
                        {
                            if (searchId.bId == borrow.borrowerBookId)
                            {
                                searchId.bCount = searchId.bCount - borrow.borrowCount;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Only {0} books are found", searchId.bCount);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Book Id {0} not found", borrow.borrowerBookId);
                }
                borrowers.Add(borrow);
            }
        

    }
}

  