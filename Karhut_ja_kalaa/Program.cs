using System;

namespace Karhut_ja_kalaa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Otta kalan määrää");
            int number=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Kaikki karhu saa "+number/4+" fish");
            System.Console.WriteLine("Kissa saa "+number%4+" fish");

            List<int> listnumber = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                    if (i%4 > i/4)
                    {
                        listnumber.Add(i);
                    }
            }
            
            foreach (int item in listnumber)
            {
              System.Console.Write(item+" ");  
            }
            
        }
    }
}