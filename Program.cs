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
            Book b = new Book("Jaryd", "Travis", "10101001010101001",2004);
            //FileHandler booksBorrowed = new FileHandler("C:\\Users\\keown\\source\\repos\\ConsoleApp12\\BooksBorrowed.txt");

            inventory.getData();
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            inventory.addData(b);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");

            inventory.getData();
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");




            //Console.WriteLine(booksBorrowed.count());




            Console.ReadKey();
        }
    }
}
