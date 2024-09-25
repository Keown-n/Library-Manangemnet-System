using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    class Program
    {
        static void Main(string[] args)
        {
             // Path to your text file

            FileHandler inventory = new FileHandler("C:\\Users\\keown\\source\\repos\\ConsoleApp12\\Library.txt");
            FileHandler booksBorrowed = new FileHandler("C:\\Users\\keown\\source\repos\\ConsoleApp12\\BooksBorrowed.txt");
            Book b = new Book("John", "Stone", "12345678890", 2073);

            if (inventory.exist()) {

                Console.WriteLine("exist");
            }

           try
            {
                // Read the entire file into a string variable
                // Read all lines of the file into a list


                /* 

                 inventory.getData();
                 Console.WriteLine("//////////////////////////////////////////////////////////////////////");


                 inventory.removeData(b);

                 Console.WriteLine("//////////////////////////////////////////////////////////////////////");
                 inventory.getData();*/

                inventory.isAvaliable(b);
                
                inventory.addData(b);

                inventory.isAvaliable(b);




            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }




            Console.ReadKey();
        }
    }
}
