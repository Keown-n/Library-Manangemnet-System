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
            string filePath = "C:\\Users\\keown\\source\\repos\\ConsoleApp12\\Library.txt"; // Path to your text file

            if (File.Exists(filePath))
            {
                Console.WriteLine("exists");
            }
            else
            {
                Console.WriteLine("no");
            }

           try
            {
                // Read the entire file into a string variable
                // Read all lines of the file into a list
                List<string> lines = new List<string>(File.ReadAllLines(filePath));
                List<List<string>> splitLines = new List<List<string>>();

                for (int i = 0; i < lines.Count; i++)
                {
                    // Split each line at "/" and convert to List<string>
                    List<string> parts = new List<string>(lines[i].Split('/'));

                    // Add the list of parts to the splitLines list
                    splitLines.Add(parts);
                }

                // Output the results
                for (int i = 0; i < splitLines.Count; i++)
                {
                    Console.WriteLine($"Line {i + 1}:");
                    foreach (var part in splitLines[i])
                    {
                        Console.WriteLine(part);
                    }
                    Console.WriteLine(); // New line for better readability
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }




            Console.ReadKey();
        }
    }
}
