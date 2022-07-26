using System;
using System.Collections.Generic;

namespace cs_con_Library
{
    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<Borrower> borrowers = new List<Borrower>();
        static List<Newspaper> newsList = new List<Newspaper>();

        static Book book = new Book();
        static Borrower borrower = new Borrower();
        static Newspaper news = new Newspaper();

        static void Main(string[] args)
        {
            Console.WriteLine("\n\n************   Library Management System  *************** ");
            Console.WriteLine("\n  Select who are you:");
            Console.WriteLine("\n     1.Borrower\n     2.Librarian\n     3.Exit");

            Console.Write("\nEnter value:");
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    {
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("                    Welcome in Library!!    ");
                        Console.WriteLine("----------------------------------------------------");
                        Console.Write("Enter your Password : ");
                        string password = Console.ReadLine();

                        //check condition password matched then go inside if block
                        if (password == "pass")
                        {

                            Console.WriteLine("Select your choice:");
                            Console.WriteLine("1.Book\n2.Newspaper\n3.Exit");
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("Enter value:");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        bool close = true;
                                        while (close)
                                        {
                                            Console.WriteLine("\nMenu\n1)Get Book\n2)Search Book\n3)Return Book\n4)Borrow Book\n5)Display\n6)Close\n\n");
                                            Console.Write("Choose Your  option from menu:");

                                            int option = int.Parse(Console.ReadLine());

                                            if (option == 1)
                                            {
                                                Book.GetBook();                         //Call GetBook method
                                            }

                                            else if (option == 2)
                                            {
                                                Book.SearchBook();                      //call SearchBook method
                                            }

                                            else if (option == 3)
                                            {

                                                Book.ReturnBook();                      //call ReturnBook method
                                            }
                                            else if (option == 4)
                                            {
                                                Borrow();                                //call Borrow method
                                            }
                                            else if (option == 5)
                                            {
                                                Book.Display();                         //call Display method
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
                                    break;

                                case 2:
                                    {
                                        bool close = true;
                                        while (close)
                                        {
                                            Console.WriteLine("\nMenu\n1)Borrow Newspaper\n2)Return Newspaper \n3)Display paper name\n4)Close\n\n");
                                            Console.Write("Choose Your  option from menu:");

                                            int option = int.Parse(Console.ReadLine());

                                            if (option == 1)
                                            {
                                                Newspaper.GetNewspaper();                         //Call GetNewspaper method
                                            }

                                            else if (option == 2)
                                            {
                                                Newspaper.Return();                         //call Return method
                                            }
                                            else if(option == 3)
                                            {
                                                Newspaper.DisplayNewspaper();
                                            }
                                            else if (option == 4)
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
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Invalid Choice");
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Password ");
                        }
                           
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Welcome in Library!!");
                        Console.WriteLine("**************************************************************");
                        Console.Write("Enter your Password : ");
                        string password = Console.ReadLine();

                        if (password == "pass123")
                        {
                            bool close = true;
                            while (close)
                            {
                                Console.WriteLine("\n\nMenu\n1)Search Book\n2)Issue Book\n3)Get Book from borrower\n4)Close\n\n");
                                Console.Write("Choose Your  option from menu:");

                                int option = int.Parse(Console.ReadLine());

                                if (option == 1)
                                {
                                    Librarian.SearchBookForBorrower();                  //Search book for the Borrower
                                }
                                else if (option == 2)
                                {
                                    Book.IssueBook();                                  //Issued book list
                                }
                                else if (option == 3)
                                {
                                    Librarian.AddBookAfterReceiving();                  //Add book after receiving from Borrower
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
                        else
                        {
                            Console.WriteLine("Invalid Password");
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

  