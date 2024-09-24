﻿using System;

namespace ConsoleApp12
{

    public class Book {

        // Private fields for encapsulation
        private string title;
        private string author;
        private string isbn;
        private int publicationYear;

        // Public properties with get and set methods
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int PublicationYear
        {
            get { return publicationYear; }
            set
            {
                // Example of validation inside the set method
                if (value > 0)
                {
                    publicationYear = value;
                }
                else
                {
                    throw new ArgumentException("Publication year must be a positive number.");
                }
            }
        }

        // Constructor using the 'this' keyword to refer to properties
        public Book(string title, string author, string isbn, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.publicationYear = publicationYear;
        }

    }
}
