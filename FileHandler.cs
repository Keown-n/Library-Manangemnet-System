using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp12
{
    class FileHandler {

        string path;

        public FileHandler(string path)
        {
            this.path = path;
        }

        public Boolean exist() {

            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false; 
            }

        }

        public void getData()
        {
            //gets file data
            List<string> fileData = new List<string>(File.ReadAllLines(path));
            List<string> lines = new List<string>();

            for (int i = 0; i < fileData.Count; i++)
            {
                String[] line = fileData[i].Split('/');

                lines.Add("Title :"+ line[1]+"\nAuthor:"+line[2]+ "\nISBN:"+line[0] +"\nYear:"+line[3]+"\n\n");

                

            }

            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

        }
        public void addData(Book book) 
        {
            //Adds data to file
            File.AppendAllText(path,  book.Isbn + "/" + book.Title + "/" + book.Author + "/" + book.PublicationYear);
            Console.WriteLine("File has been update");
        }

        public void removeData(Book book) 
        {
            string[] lines = File.ReadAllLines(path);
            string lineToRemove = book.Isbn + "/" + book.Title + "/" + book.Author + "/" + book.PublicationYear;

            // Filter out the line that matches exactly
            string[] updatedLines = Array.FindAll(lines, line => line != lineToRemove);

            // Write the updated lines back to the file
            File.WriteAllLines(path, updatedLines);

            Console.WriteLine("The specified line has been removed.");
        }

        public Boolean isAvaliable(Book book) {

            string searchText = book.Isbn + "/" + book.Title + "/" + book.Author + "/" + book.PublicationYear;


            // Read all lines from the file
            string[] lines = File.ReadAllLines(path);
            

            // Search for the specified text in each line
            foreach (string line in lines)
            {
                if (line.Contains(searchText)) // Case-insensitive search
                {
                     // Print the line that contains the search text
                    return true;
                }
            }

            return false;

            
        }

    }
}
