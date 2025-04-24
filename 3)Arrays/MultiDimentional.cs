using System;

namespace Mynamespace
{
    public class multiDArrays
    {
        public static void Main()
        {
            int[,] a = new int[3,2];
            Console.WriteLine($"rows {a.GetLength(0)}");
            Console.WriteLine($"cols {a.GetLength(1)}");

            Console.WriteLine("Reading into Array:");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write("Enter:");
                    a[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Writing");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write($"value:{a[i,j]} ");
                }
                Console.Write("\n");
            }
        }

    }
}