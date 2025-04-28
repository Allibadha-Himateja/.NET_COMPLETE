using System;

namespace MySpace
{
    class LinkedList
    {
        private int data;
        private LinkedList next, first, prev, top;
        private int count;

        public LinkedList()
        {
            count = 0;
        }

        public void add(int i)
        {
            nw = new LinkedList();
            nw.data = i;
            nw.next = null;
            if (first == null)
            {
                first = nw;
            }
            else
            {
                prev.next = nw;
            }
            prev = nw;
        }

        public void display()
        {
            top = first;
            while (top != null)
            {
                Console.WriteLine(top.data);
                top = top.next;
            }
        }

        public int Size()
        {
            int count=0
            top = first;
            while (top != null) {
                count++;
            }
            return count;
        }
    }

    class program
    {
        public static void Main()
        {
            LinkedList list=new LinkedList();
            list.add(100);
            list.add(200);
            list.add(300);
            Console.WriteLine("size of list:"+list.Size());
            list.display();
        }
    }
}