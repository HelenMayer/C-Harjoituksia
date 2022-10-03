using System;

namespace Arvuutuskone
{
    public class Program{
        public static void Main(string[] args)
        {
            int number;
            int guessNumber;

            while (true)
            {
                System.Console.WriteLine("User 1, enter a number between 0 and 100:");
                number=Convert.ToInt32(Console.ReadLine());
                if (number>=0 && number<=100)
                {
                    break;
                }
                System.Console.WriteLine("Hey! Enter a number between 0 and 100!");
            }
            System.Console.WriteLine("User 2, guess the number.");
            while (true)
            {
                guessNumber=Convert.ToInt32(Console.ReadLine());

                if (number==guessNumber)
                {
                    System.Console.WriteLine("You guessed the number!");
                    break;
                }
                if (Math.Abs(number-guessNumber)<10 && number!=guessNumber)
                {
                    System.Console.WriteLine(guessNumber+" is beside! Try again!");
                }
                if (number-guessNumber<= -10)
                {
                    System.Console.WriteLine(guessNumber+" is too high.");
                }
                if (number-guessNumber>= 10)
                {
                    System.Console.WriteLine(guessNumber+" is too low.");
                }
            }
        }
    }
}