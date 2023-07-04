using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace consoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int computerNumber = rand.Next(1000);
            Boolean isContinue = true;
            while (isContinue) {        
                Console.Write("Enter number: ");
                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber == computerNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your answer is right :-)");
                    Console.ResetColor();
                    isContinue = false;
                    continue;
                }
                else if (userNumber < computerNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Choose greater number!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Choose lower number!");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Good job! Bye!");
            Console.ReadKey();

        }
    }
}
