using System;

namespace Vastaluku
{
    public class Program{
        public static void Main(string[] args){
            int [,] array = new int [5,4]; 
            Random rnd = new Random();
    
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    array[i,j]=rnd.Next(10, 25);
                    Console.Write(array[i,j]+" ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("New array");
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    array[i,j]=-array[i,j];
                    Console.Write(array[i,j]+" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}