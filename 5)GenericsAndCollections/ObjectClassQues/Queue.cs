using System;

namespace MySpace
{
    class Queue
    {
        private int[] arr;
        private int top,end;
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
                Console.WriteLine(arr[i]+" ");
            }
        }
    }
}