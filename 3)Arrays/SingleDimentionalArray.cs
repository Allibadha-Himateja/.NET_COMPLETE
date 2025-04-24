using System;

namespace Mynamespace
{
    public class Arrays
    {
        public static void Main()
        {
            string[] arr = new string[5];
            for(int i= 0;i<5;i++)
            {
                Console.Write("Enter String:");
                arr[i]=Console.Read();
            }
            foreach(string i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
