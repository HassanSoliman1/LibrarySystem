using System;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the library system");
            Library library = new Library();
            Console.WriteLine("Are you Librarian or Regular user (L / R)");

            char userType = Console.ReadLine().ToUpper()[0];


            if (userType == 'L')
            {
                Console.WriteLine("Welcom Librarian ,Enter your name");

                string librarianName = Console.ReadLine();

                Librarian L1 = new Librarian(librarianName);

                Console.WriteLine($"Welcome {L1.Name}");

                while (true)
                {
                    Console.WriteLine("Please choose to Add book (A) / Remove book (R) / Display books (D)");

                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = int.Parse(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };

                            L1.AddBook(book, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter book details to remove");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = int.Parse(Console.ReadLine());

                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };

                            L1.Remove(book, library);
                            break;

                        case 'D':
                            Console.WriteLine(" The book list :");
                            L1.DisplayBook(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }


                }
            }
            else if (userType == 'R')
            {
                Console.WriteLine("Welcom User ,Enter your name");
                string name = Console.ReadLine();
                                
                LibraryUser L1User = new LibraryUser(name);

                Console.WriteLine($"Welcome {L1User.Name}");
                

                while (true)
                {
                    Console.WriteLine("Please choose to Borrow book (A) / Display books (D)");

                    char choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details to borrow");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = int.Parse(Console.ReadLine());

                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };

                            L1User.BorrowBook(book, library);
                            break;


                        case 'D':
                            Console.WriteLine(" List of borrowed books :");
                            L1User.DisplyBooksBorrowed(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }


                }
            }
            else
            {
                Console.WriteLine("Please enter correct value ( L or R )");
            }

        }


    }


}
