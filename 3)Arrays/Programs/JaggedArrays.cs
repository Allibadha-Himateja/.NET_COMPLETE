using System;

class JaggedArray
{
    public static void Main()
    {
        int [,]ja = new int[3,2];
        // THIS IS AN IMPLEMENTATION OF JAGGED ARRAYS IN .NET 
        // A JAGGED ARRAY IS A ARRAY WHICH HAS NO OF ROWS!=NO OF COLUMNS
        
        for(int i = 0;i<ja.GetLength(0);i++)
        {
            for(int j=0;j<async.GetLength(1);j++)
            {
                Console.Write("Enter:");
                ja[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for(int i = 0;i<ja.GetLength(0);i++)
        {
            for(int j=0;j<ja.GetLength(1);j++)
            {
                Console.Write($"{ja[i,j]}");
                //ja[i,j] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n");
        }
        
    }
}