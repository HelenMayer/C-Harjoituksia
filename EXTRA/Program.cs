using System;

namespace EXTRA
{
    public class Program{
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int distance=rnd.Next(0,100);

            int i=1;
            int pelajandistance;
            Boolean check=true;

            Ampua ampua= new Ampua();
            Terveys kaupunki = new Terveys();
            Terveys lohikäärme = new Terveys();

            kaupunki.TerveusArvo(15);
            lohikäärme.TerveusArvo(10);

            while (check)
            {
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("TILANNE: Kierros:"+i+" Kaupunki: "+kaupunki.PrintTerveArvo()+"/15 Lohikäärme "+lohikäärme.PrintTerveArvo()+"/10" );
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("Kanuuna tekee "+ampua.Ampuarvo(i)+" pistettä vahinko tällä vuorolla");
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Mille etäisuudelle kanuunalla ammutaan: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                pelajandistance=Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine(ampua.Ampu(pelajandistance, distance, kaupunki, lohikäärme));
                System.Console.WriteLine();
                i++;
                if (kaupunki.PrintTerveArvo()<=0)
                {
                    check=false;
                    System.Console.WriteLine("Lohikäärme win!");
                }
                if (lohikäärme.PrintTerveArvo()<=0)
                {
                    check=false;
                    System.Console.WriteLine("Kaupunki win!");
                }
            }
        }
    }
}