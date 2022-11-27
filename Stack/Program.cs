using System;

namespace Stack
{
    public class Stack<T>
    {
        public class Node<T>
        {
            public Node<T> next;
            public T value;
            public Node(T value)
            {
                this.value = value;
                next = null;
            }

        }
        private Node<T> up;
        private Node<T> down;
        private int count = 0;

        public T GetUp()
        {
            if (up == null)
            {
                return default(T);
            }
            else { return up.value; }
        }
        public T GetDown()
        {
            if (down == null)
            {
                return default(T);
            }
            else { return down.value; }
        }
        public int GetCount()
        {
            return count;
        }
        public void Print()
        {
            string values = "";
            Node<T> start = up;
            while (start != null)
            {
                values += start.value.ToString() + " ";
                start = start.next;
            }
            Console.WriteLine(values);
        }
        public void Push(T x)
        {
            Node<T> a = new Node<T>(x);
            if (count == 0)
            {
                up = a;
                down = a;
            }
            else
            {
                a.next = up;
                up = a;
            }
            count += 1;
        }
        public T Pop()
        {
            if (count != 0)
            {
                Node<T> rtrn = up;
                if (count == 1)
                {
                    up = null;
                    down = null;
                }
                else
                {
                    up = up.next;
                }
                count -= 1;
                return rtrn.value;
            }
            return default(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
