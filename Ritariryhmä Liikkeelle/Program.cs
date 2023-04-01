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

            if (riiviNumber-1>0 && sarakeNumber>0 && riiviNumber-1<=8 && sarakeNumber<=8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                System.Console.WriteLine("Ritari yksi kohteeseen "+(riiviNumber-1)+";"+(sarakeNumber)); 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Ritari yksi kohteeseen on pois shakkilaudalta"); 
            }
                        
            if (riiviNumber>0 && sarakeNumber+1>0 && riiviNumber<=8 && sarakeNumber+1<=8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                System.Console.WriteLine("Ritari kaksi kohteeseen "+riiviNumber+";"+(sarakeNumber+1)); 
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Ritari kaksi kohteeseen on pois shakkilaudalta"); 
            }            
            
            if (riiviNumber>0 && sarakeNumber-1>0 && riiviNumber<=8 && sarakeNumber-1<=8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                System.Console.WriteLine("Ritari kolme kohteeseen "+riiviNumber+";"+(sarakeNumber-1));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Ritari kolme kohteeseen on pois shakkilaudalta"); 
            }            
            
            if (riiviNumber+1>0 && sarakeNumber>0 && riiviNumber+1<=8 && sarakeNumber<=8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                System.Console.WriteLine("Ritari neljä kohteeseen "+(riiviNumber+1)+";"+(sarakeNumber));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Ritari neljä kohteeseen on pois shakkilaudalta"); 
            }

        }
    }
}