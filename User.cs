namespace ConsoleApp12
{
    abstract class User {

        public abstract void borrowBook(Book book);
        public abstract void returnBook(Book book);
        public abstract int numberOfBooksBorrowed();
        public abstract string mostPopular();
        public abstract void overDueBook();
        public abstract void addBook(Book book, FileHandler file);
        public abstract void removeBook(Book book, FileHandler file);    
    
    }

    class Librarian : User{

        private string username;
        

        // Public property for 'username' with get and set methods
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        // Public property for 'password' with get and set methods
        

        // Constructor
        public Librarian(string username)
        {
            this.Username = username;
            
        }

        public override void addBook(Book book, FileHandler file)
        {
            file.addData(book);
            System.Console.WriteLine("Book has been added to the file");
        }

        public override void removeBook(Book book, FileHandler file)
        {
            file.removeData(book);
            System.Console.WriteLine("Book has been removed from the file");
        }

        public override void borrowBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public override void returnBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public override int numberOfBooksBorrowed()
        {
            throw new System.NotImplementedException();
        }

        public override string mostPopular()
        {
            throw new System.NotImplementedException();
        }

        public override void overDueBook()
        {
            throw new System.NotImplementedException();
        }
    }

    class Admin : User {

        private string username;
        

        // Public property for 'username' with get and set methods
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

       

        // Constructor
        public Admin(string username)
        {
            this.Username = username;
         
        }

        public override int numberOfBooksBorrowed()
        {   
            //Returns the number of books borrowed from the file

            return 1;
            throw new System.NotImplementedException();
        }

        public override string mostPopular()
        {   
            //returns the most popular book from file
            return "book";

            throw new System.NotImplementedException();
        }

        public override void overDueBook()
        {
            //returns the books overdue
            // implements reminder...maybe

            throw new System.NotImplementedException();
        }

        public override void borrowBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public override void returnBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public override void addBook(Book book, FileHandler file)
        {
            throw new System.NotImplementedException();
        }

        public override void removeBook(Book book, FileHandler file)
        {
            throw new System.NotImplementedException();
        }
    }

    class Member : User
    {
        private string username;
       

        // Public property for 'username' with get and set methods
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        

        // Constructor
        public Member(string username, string password)
        {
            this.Username = username;
        }

        public override void borrowBook(Book book)
        {
            //borrows book and adds it to the file for borrowed books with user name
            throw new System.NotImplementedException();
        }

        public override void returnBook(Book book)
        {
            //borrows book
            throw new System.NotImplementedException();
        }

        public override int numberOfBooksBorrowed()
        {
            throw new System.NotImplementedException();
        }

        public override string mostPopular()
        {
            throw new System.NotImplementedException();
        }

        public override void overDueBook()
        {
            throw new System.NotImplementedException();
        }

        public override void addBook(Book book, FileHandler file)
        {
            throw new System.NotImplementedException();
        }

        public override void removeBook(Book book, FileHandler file)
        {
            throw new System.NotImplementedException();
        }
    }
}
