using System;

namespace Lihapiirakka_ongelma
{
    public class Program{
        public static void Main(string[] args){
            System.Console.WriteLine("How much money do you have?");
            double money=Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("how much is the pie?");
            double pie=Convert.ToDouble(Console.ReadLine());
            
            if (money>=pie)
            {
                System.Console.WriteLine("You can buy pie! Money: "+Math.Round(money-pie, 2));
            }
            else
            {
                System.Console.WriteLine("The fasts!");
            }
        }
    }
}