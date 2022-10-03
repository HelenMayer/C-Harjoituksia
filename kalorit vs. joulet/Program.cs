using System;

namespace kalorit_vs_joulet
{
    public class Program{
        public static void Main(string[] args){
            System.Console.WriteLine("Valikko: ");
            System.Console.WriteLine("1. Kalorit jouleiksi");
            System.Console.WriteLine("2. Joulet kaloreiksi");
            System.Console.WriteLine("Valitse muunnos:");
            int input=Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1: 
                    System.Console.WriteLine("Anna kalorit määrä");
                    int kalori=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine(kalori*4.184);
                    break;
                case 2:
                    System.Console.WriteLine("Anna joulen määrä");
                    int jouli=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine(jouli*0.2390);
                    break;
                default: System.Console.WriteLine("Valita oikein numero"); break;
            }
        }
    }
}