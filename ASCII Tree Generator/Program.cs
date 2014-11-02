using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Tree_Generator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("        -- ASCII Tree Generator --");
            Console.WriteLine("Generates an ASCII tree based on user input.");
            Console.WriteLine("Sample input: 7 ^ #");
            Console.WriteLine("Sample output: ");
            Console.WriteLine("   ^");
            Console.WriteLine("  ^^^");
            Console.WriteLine(" ^^^^^");
            Console.WriteLine("^^^^^^^");
            Console.WriteLine("  ###");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Get user input
            Console.Write("Enter ASCII tree specs: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();

            try {
                // Parse specs from user input
                var parts = userInput.Split(' ');
                int treeWidth = Convert.ToInt32(parts[0]);
                char leafChar = Convert.ToChar(parts[1]);
                char baseChar = Convert.ToChar(parts[2]);

                
            } catch(Exception ex) { // Pokemon exception handling
                Console.WriteLine("!!! Invalid input !!!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
