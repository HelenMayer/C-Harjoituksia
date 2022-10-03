using System;

namespace PIN_ja_PUK_koodit
{
    public class Program{
        public static void Main(string[] args){
            string pinkoodi = "0123";
            string puckoodi= "12345678";
            Boolean pincheck=true;
            int k=0;
            int n=0;
            Boolean puccheck=false;

            System.Console.WriteLine("Give a PIN-code");

            link:
            while (pincheck)
            {
                string inputpinkoodi=Console.ReadLine();
                if (inputpinkoodi==pinkoodi)
                {
                    System.Console.WriteLine("Correct! Come in!");
                    break;
                }
                else
                {
                    k++;
                    System.Console.WriteLine("Not correct! Try again");
                }
                if (k==3)
                {
                    pincheck=false;
                    puccheck=true;
                    System.Console.WriteLine("Give a PUC-code");
                }
            }

            while (puccheck)
            {
                string inputpuckoodi=Console.ReadLine();
                if (inputpuckoodi==puckoodi)
                {
                    System.Console.WriteLine("Correct! Give a PIN-code");
                    pincheck=true;
                    puccheck=false;
                    goto link;
                }
                else
                {
                    n++;
                    System.Console.WriteLine("Not correct! Try again");
                }
                if (n==3)
                {
                    System.Console.WriteLine("Sorry, program not work");
                    break;
                }
            }

            
        }
    }
}