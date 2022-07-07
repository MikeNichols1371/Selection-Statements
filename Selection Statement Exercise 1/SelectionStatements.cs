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
            var favNumber = r.Next(15);
            var userInput = int.Parse(Console.ReadLine());




            if (userInput <= 14)
            {
                Console.WriteLine("Too low.");
            }
            else if (userInput >= 16)
            {
                Console.WriteLine("Too High.");
            }
            if (userInput == 15)
            {
                Console.WriteLine("You guessed it!!!");
            }
        } 
    }
}
