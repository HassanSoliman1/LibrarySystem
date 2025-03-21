using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal abstract class User
    {
        public string Name { get; set; }

        public void DisplayBook(Library library)
        {
            library.Display();

        }

        public void DisplyBooksBorrowed(Library library)
        {
            library.DisplayBooksBorrowed();

        }

    }
}
