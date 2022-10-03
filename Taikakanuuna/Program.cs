using System;

namespace Taikakanuuna
{
    public class Program{
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%3!=0 && i%5!=0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine(i+": Normal");
                }
                if (i%3==0 && i%5!=0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(i+": Fire");
                }
                if (i%3!=0 && i%5==0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine(i+": Electric");
                }
                if (i%3==0 && i%5==0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine(i+": Electric and Fire");
                }
            }
        }
    }
}