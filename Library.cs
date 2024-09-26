using System.IO;

namespace ConsoleApp12
{
    class Library 
    {
        private Librarian librarian;
        private FileHandler inventory = new FileHandler("C:\\Users\\keown\\source\\repos\\ConsoleApp12\\Library.txt");
        private FileHandler booksBorrowed = new FileHandler("C:\\Users\\keown\\source\repos\\ConsoleApp12\\BooksBorrowed.txt");
        
        public Library(Librarian x)
        {
            this.librarian = x;
        }
        public void addBookToInventory(Book book) {
            //in the library class the librarian adds a book to the library 
            // adds a book to the Library file
            librarian.addBook(book, inventory);
           
        }

        public void removeBookFromInventory(Book book) {

            //the librarian removes a book from the library
            //removes booke from library file
            librarian.removeBook(book,inventory);

        }

        public void addBookToBorrowed(Book book)
        {
            librarian.addBook(book, booksBorrowed);
        }

        public void removeBookFromBorrowed(Book book)
        {
            librarian.removeBook(book, booksBorrowed);
        }

        public void Borrow() { 
        
        
        }


    }
}
