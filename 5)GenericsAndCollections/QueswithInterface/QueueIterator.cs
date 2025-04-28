using System;
namespace MySpace
{
    interface Iterator
    {
        public virtual bool hasNext();
        public virtual int next();
    }

    class Queue : Iterator
    {
        private int[] arr;
        private int top, end;
        public Queue()
        {
            arr = new int[10];
            top = 0;
            end = 0;
        }
        public void Enqueue(int item)
        {
            arr[end++] = item;
        }
        public int Dequeue()
        {
            return arr[top++];
        }
        public bool isEmpty()
        {
            return end == 0 && top == 0;
        }
        public void display()
        {
            for (int i = top; i < end; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        public override bool hasNext()
        {
            return count > 0;
        }
        public virtual int next()
        {
            return (int) arr[top++];
        }
    }
}