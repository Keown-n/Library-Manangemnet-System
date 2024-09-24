using System.IO;

namespace ConsoleApp12
{
    class Library 
    {
        private Librarian librarian;

        

        public Library(Librarian x)
        {
            this.librarian = x;
        }

        /*create file variables for

        -Books in the library
        -borrowed books
        -overdue books
        -most books taken ( Create a file with a list of books and number of times taken)

        */



        public void addBook(Book book) {
            //in the library class the librarian adds a book to the library 
            // adds a book to the Library file
            librarian.addBook(book);
           
        }

        public void removeBook(Book book) {

            //the librarian removes a book from the library
            //removes booke from library file
            librarian.removeBook(book);

        }

    }
}
