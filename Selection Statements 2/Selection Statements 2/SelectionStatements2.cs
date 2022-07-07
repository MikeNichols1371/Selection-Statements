using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Statements_2
{
    internal class SelectionStatements2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?: ");

            var r = new Random();
            string favSubject = Console.ReadLine();
            
            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Math is cool");
                    break;
                case "History":
                    Console.WriteLine("History is cool");
                    break;
                case "Science":
                    Console.WriteLine("Science is cool");
                    break;
                case "English":
                    Console.WriteLine("English is cool");
                    break;
                case "Lunch":
                        Console.WriteLine("Lunch is the best");
                    break;
                default:
                        Console.WriteLine("I forgot about that one");
                    break;



            }


        }

        
        
    }
}
