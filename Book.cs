using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }



       
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Book otherBook = (Book)obj;
            return this.Title == otherBook.Title && this.Author == otherBook.Author && this.Year == otherBook.Year;
        }

       
        public override int GetHashCode()
        {
            return Title.GetHashCode() ^ Author.GetHashCode() ^ Year.GetHashCode();
        }
    }


}

