using System;

namespace Excercise_13_14_15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool LoopContinueYN = true;
            while (LoopContinueYN)
            {
                Console.WriteLine("Please enter a number: ");
                int userNumber = int.Parse(Console.ReadLine());


                for (int i = userNumber; i >= 0; i = i - 1)
                {
                   Console.WriteLine(i);
                    //this is the output of all numbers from userInput to zero.
                }
                
                for (int i = 1; i <= userNumber; i++)
                {

                    Console.WriteLine(i * i);
                   //this is the output of the squares of all the numbers from 1 up to userInput.
                }

                for (int i = 1; i <= userNumber; i++)
                {
                   Console.WriteLine(Math.Pow(i, 4));
                   //this is hte output of the cubes of all the numbers from 1 up to the userInput.
                }

                Console.WriteLine("Would you like to continue? Y/N");
                string userInput = Console.ReadLine();


                if (userInput.ToLower() == "y")
                {
                    Console.WriteLine("Awesome!");
                }
                else
                {
                    Console.Write("Thank you, Goodbye!");
                    LoopContinueYN = false;

                }

            }
        }
    }
}
