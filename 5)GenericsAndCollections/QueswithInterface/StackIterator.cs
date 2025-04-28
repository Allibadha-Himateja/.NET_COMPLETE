using System;
namespace MySpace
{
    interface Iterator
    {
        public virtual bool hasNext();
        public virtual int next();
    }
    class Stack : Iterator
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

        public override bool hasNext()
        {
            return count > 0;
        }
        public override int next()
        {
            return arr[count--];
        }

    }
}