using System;

namespace Kivi_paperi_jas_akset{
    public class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Let's play!");
            System.Console.WriteLine("1 = Kivi, 2 = Paperi, 3 = Sakset ?");
            int input=Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int computer=rnd.Next(1,3);

            if ((input==1 && computer==3) | ((input==2 && computer==1)) | (input==3 && computer==2))
            {
                System.Console.WriteLine("People: "+input+", computer: "+computer+ " People win!");
            }
            if ((input==3 && computer==1) | (input==1 && computer==2) | (input==2 && computer==3))
            {
                System.Console.WriteLine("People: "+input+", computer: "+computer+ " Computer win!");
            }
            if (input==computer)
            {
                System.Console.WriteLine("People: "+input+", computer: "+computer+ " Draw!");
            }
        }
    }
}