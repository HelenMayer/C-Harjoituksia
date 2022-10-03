namespace Valtakuntien_Herruus
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine("Otta maatilojen määrää");
            int maatilat =  Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Otta herttuakuntien määrää");
            int herttuakunnat =  Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Otta maakuntien määrää");
            int maakunnat =  Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Pistemäärä "+(maatilat*1+herttuakunnat*3+maakunnat*6));


        }
    }
}