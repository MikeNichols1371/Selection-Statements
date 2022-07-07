using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Statement_Exercise_1
{
    internal class SelectionStatements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number 1-1000: ");

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());




            if (userInput < favNumber)
            {
                Console.WriteLine("Too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High.");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        } 
    }
}
