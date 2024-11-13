using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHanding
{
    internal class _10Write_readList
    {
        public static void Main(string[] args)
        {
            // Define the file path for names.txt
            string filePath = "C:\\CSharp\\Name.txt";

            // Create a list to store names
            List<string> names = new List<string>();

            Console.WriteLine("Enter names (type 'done' to finish):");

            // Take input from the user until they type 'done'
            while (true)
            {
                string input = Console.ReadLine();

                // Check if the user typed 'done' to stop
                if (input.ToLower() == "done")
                {
                    break;
                }

                // Add the entered name to the list
                names.Add(input);
            }

            // Write names to the file
            try
            {
                // Write all names to names.txt
                File.WriteAllLines(filePath, names);

                Console.WriteLine("\nNames have been written to 'names.txt'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }

            // Read names from the file and display them
            try
            {
                // Check if the file exists before trying to read it
                if (File.Exists(filePath))
                {
                    string[] fileContents = File.ReadAllLines(filePath);

                    Console.WriteLine("\nNames read from 'names.txt':");
                    foreach (string name in fileContents)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    Console.WriteLine($"The file '{filePath}' does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
