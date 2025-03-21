using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private Book[] Books = new Book[100];
        private int CurrentBookCount = 0;

        private Book[] BorrowedBooks = new Book[50];
        private int CurrentBorrwedBookCount = 0;



        public void Display()
        {
           
            for(int i = 0; i <CurrentBookCount; i++)
            {
                if(Books[i] == null)
                continue;
                Console.WriteLine(Books[i].Title); 

            }
            
        }

        public void DisplayBooksBorrowed()
        {

            for (int i = 0; i < CurrentBorrwedBookCount; i++)
            {
                if (BorrowedBooks[i] == null)
                    continue;
                Console.WriteLine(BorrowedBooks[i].Title);

            }

        }
        public void Add(Book book)
        {
            if (CurrentBookCount < Books.Length) 
            {
                Books[CurrentBookCount] = book;  
                CurrentBookCount++;
                Console.WriteLine("BOOK ADDED SUCCESSFLLY");
            }
            else
            {
                Console.WriteLine("Library is Full , Can not add new books");
            }                
        }

        public void BorrowBook(Book book)
        {
            if (CurrentBorrwedBookCount < BorrowedBooks.Length)
            {
                BorrowedBooks[CurrentBorrwedBookCount] = book;
                CurrentBorrwedBookCount++;
                Console.WriteLine("BOOK BORROED SUCCESSFLLY");
            }
            else
            {
                Console.WriteLine("Sorry Can't Borrow More Books");
            }
        }

        public void Remove(Book book)
        {
            int index = Array.IndexOf(Books, book);

            if (index != -1)
            {
                Console.WriteLine("Book found at index " + index);
                Books[index] = null;
                CurrentBookCount--;
                Console.WriteLine("Book Removed");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }


    }
}
