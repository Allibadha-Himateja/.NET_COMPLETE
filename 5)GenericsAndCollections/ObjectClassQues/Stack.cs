using System;

namespace MySpace
{
    class Stack
    {
        private int[] arr;
        private int count;
        public Stack()
        {
            arr = new int[10];
            count = 0;
        }
        public void push(int i)
        {
            arr[count++] = i;
        }
        public int pop()
        {
            return arr[count--];
        }

        public bool isEmpty()
        {
            return count == 0;
        }
    }
}