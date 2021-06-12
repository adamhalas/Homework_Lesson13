using System;

namespace Homework_Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz class instantiation
            FizzBuzz fb = new FizzBuzz();

            Console.WriteLine("***********************");
            Console.WriteLine("FizzBuzz... let's play!");
            Console.WriteLine("***********************");

            var play = true;

            while (play)
            {
                //number validation method - GetValid()
                int number = GetValid();


                //Displaying the final score
                Console.WriteLine(fb.GetScore(number));


                char playAgain = getValidLetter();

                if (playAgain == 'y')
                {
                    continue;
                }

                play = false;
            }

            Console.WriteLine("\nThanks for your time! See you around! ");
            Console.WriteLine("Game is over, press Enter...");

            Console.ReadLine();



        }

        private static char getValidLetter()
        {
            char validLetter;

            while (true)
            {
                Console.Write("\nContinue? [y/n]: ");

                if (!Char.TryParse(Console.ReadLine(), out char letter) || (letter != 'y' && letter != 'n'))
                {
                    Console.WriteLine("\nRemember, press 'y' or 'n', try again!");
                    continue;
                }
                validLetter = letter;
                break;
            }
            return validLetter;

        }

        private static int GetValid()
        {
            while (true)
            {
                //Getting number from the user
                Console.Write("Enter your number, please: ");

                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("What you entered was not a number. Try again!");
                    continue;
                }
                return num;
            }
        }
    }
}
