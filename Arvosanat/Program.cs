using System;
namespace Arvosanat
{
    public class Program{
        public static void Main(string[] args){
            int arvosana=Convert.ToInt32(Console.ReadLine());
            switch (arvosana)
            {
                case 0: System.Console.WriteLine("hylätty"); break;
                case 1: System.Console.WriteLine("välttävä"); break;
                case 2: System.Console.WriteLine("tyydyttävä"); break;
                case 3: System.Console.WriteLine("hyvä"); break;
                case 4: System.Console.WriteLine("kiitettävä"); break;
                case 5: System.Console.WriteLine("erinomainen"); break;
                default: System.Console.WriteLine("Give a correct number!"); break;
            }
        }
    }
}