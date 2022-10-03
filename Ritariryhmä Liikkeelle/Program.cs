namespace Ritariryhmä_Liikkeelle
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Kohde riivi?");
            int riiviNumber=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Kohde sarake?");
            int sarakeNumber=Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();
            System.Console.WriteLine("Ritari yksi kohteeseen "+(riiviNumber-1)+";"+(sarakeNumber));
            Console.Beep();
            System.Console.WriteLine("Ritari kaksi kohteeseen "+riiviNumber+";"+(sarakeNumber+1));
            Console.Beep();
            System.Console.WriteLine("Ritari kolme kohteeseen "+riiviNumber+";"+(sarakeNumber-1));
            Console.Beep();
            System.Console.WriteLine("Ritari neljä kohteeseen "+(riiviNumber+1)+";"+(sarakeNumber));

        }
    }
}