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

        public int count() {
            List<string> fileData = new List<string>(File.ReadAllLines(path));

            return fileData.Count;

        }

        public void getData()
        {
            //gets file data
            List<string> fileData = new List<string>(File.ReadAllLines(path));
            List<string> lines = new List<string>();

            for (int i = 0; i < fileData.Count; i++)
            {
                String[] line = fileData[i].Split('-');

                lines.Add("Title :"+ line[1]+"\nAuthor:"+line[2]+ "\nISBN:"+line[0] +"\nYear:"+line[3]+"\n Number of times Taken:"+line[4]+"\nDate Taken: "+line[5]+"\n");
                
            }

            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

        }
        public void addData(Book book) 
        {
            //Adds data to file
            File.AppendAllText(path,  book.Isbn + "-" + book.Title + "-" + book.Author + "-" + book.PublicationYear+"-"+book.NumberOftimes+"-"+book.Date);
            Console.WriteLine("File has been update");
        }

        public void removeData(Book book) 
        {
            string[] lines = File.ReadAllLines(path);
            string lineToRemove = book.Isbn + "-" + book.Title + "-" + book.Author + "-" + book.PublicationYear + "-" + book.NumberOftimes + "-" + book.Date;

            // Filter out the line that matches exactly
            string[] updatedLines = Array.FindAll(lines, line => line != lineToRemove);

            // Write the updated lines back to the file
            File.WriteAllLines(path, updatedLines);

            Console.WriteLine("The specified line has been removed.");
        }

        public void mostTaken() {

            string[] lines = File.ReadAllLines(path);
            string[] most = new string[5];

            for (int i = 0; i < lines.Length; i++)
            {
                // Split the line into parts using the '/' separator
                string[] parts = lines[i].Split('-');
                string[] parts2 = lines[ 1].Split('-');
               


                if (i == lines.Length-1) {

                    break;

                }
                else { 
                    

                    int taken2 = Int32.Parse(parts2[4]);
                    int taken = Int32.Parse(parts[4]);

                    if(taken>= taken2)
                    {
                        most[0] = parts[0];
                        most[1] = parts[1];
                        most[2] = parts[2];
                        most[3] = parts[3];
                        most[4] = parts[4];
                        most[5] = parts[5];

                    }
                    else if (taken < taken2)
                    {
                        most[0] = parts2[0];
                        most[1] = parts2[1];
                        most[2] = parts2[2];
                        most[3] = parts2[3];
                        most[4] = parts2[4];
                        most[5] = parts[5];
                    }
                
                }

                

            }

            Console.WriteLine(most[1]);


           

        }

        public Boolean isAvaliable(Book book) {

            string searchText = book.Isbn + "-" + book.Title + "-" + book.Author + "-" + book.PublicationYear;


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
