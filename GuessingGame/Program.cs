using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void PrintMsg(string msg, string color)
        {
            if (color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(msg);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(msg);
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the guessing game");
            Console.WriteLine("You will have 5 tries to win the game");
            Console.WriteLine("Guess a number between 1 to 100 to start the game");
            Random rand = new Random();
            int correctNumber = rand.Next(1, 100);
            int tries = 5;
            while(tries-- > 0)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == correctNumber)
                {
                    PrintMsg("Congrats! You guessed the right number", "green");
                    break;
                }
                else if (number < correctNumber && tries > 0)
                {
                    PrintMsg("Guess a bigger number", "red");
                }
                else if(tries > 0)
                    PrintMsg("Guess a smaller number", "red");
            }
            if(tries <= 0)
            {
               Console.WriteLine("The correct number is {0}",correctNumber);
            }
            Console.ReadLine();//To keep the console application running
            //I am going to add a new line for the commit
           //This is for the pull request

            //Now to see the fetch work
           
        }
    }
}
