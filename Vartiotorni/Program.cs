namespace Vartiotorni
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());

            if (x>0)
            {
                if (y>0)
                {
                    System.Console.WriteLine("The enemy is to the north east!");
                }    
                else if (y==0)
                {
                    System.Console.WriteLine("The enemy is to the north!");
                }          
                else
                {
                    System.Console.WriteLine("The enemy is to the south west!");
                }  
            }
            else if (x==0)
            {
                if (y>0)
                {
                    System.Console.WriteLine("The enemy is to the north!");
                }    
                else if (y==0)
                {
                    System.Console.WriteLine("The enemy is here!!!!");
                }          
                else
                {
                    System.Console.WriteLine("The enemy is to the south!");
                }  
            }
            else
            {
                if (y>0)
                {
                    System.Console.WriteLine("The enemy is to the north west!");
                }    
                else if (y==0)
                {
                    System.Console.WriteLine("The enemy is to the west!");
                }          
                else
                {
                    System.Console.WriteLine("The enemy is to the south west!");
                }  
            }
        }
    }
}