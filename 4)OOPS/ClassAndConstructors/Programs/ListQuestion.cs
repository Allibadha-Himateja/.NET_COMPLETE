using System;

namespace MySpace
{
    public class List
    {
        private int[] arr;
        private int count;
        public void init()
        {
            count = 0;
            arr = new int[10];
        }
        public void create(int blocks)
        {
            count = 0;
            arr=new int[blocks];
        }
        public void add(int i)
        {
            arr[count++] = i;
        }

        public int find(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == item) return i;
            }
            return -1;
        }

        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    public class program
    {
        public static void Main()
        {
            List l;
            l = new List();
            l.init();
            // init for 10 blocks
            // create for 100 blocks
            l.add(100);
            l.add(200);
            l.add(300);
            l.add(400);
            //l.print();

            // find l.find(100) pos or -1;
            Console.WriteLine(l.find(300));
        }
    }
}