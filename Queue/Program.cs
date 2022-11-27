using System;

namespace Queue
{
    public class Queue<T>
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

        private Node<T> front;
        private Node<T> back;
        private int count = 0;

        public T GetFront()
        {
            if (front == null)
            {
                return default(T);
            }
            else { return front.value; }
        }
        public T GetBack()
        {
            if (back == null)
            {
                return default(T);
            }
            else { return back.value; }
        }
        public int GetCount()
        {
            return count;
        }
        public void Print()
        {
            string values = "";
            Node<T> start = front;
            while (start != null)
            {
                values += start.value.ToString() + " ";
                start = start.next;
            }
            Console.WriteLine(values);
        }
        public void Enqueue(T x)
        {
            Node<T> a = new Node<T>(x);
            if (count == 0)
            {
                front = a;
                back = a;
            }
            else
            {
                back.next = a;
                back = a;
            }
            count += 1;
        }
        public T Dequeue()
        {
            if (count != 0)
            {
                T rtrn = front.value;
                if (count == 1)
                {
                    front = null;
                    back = null;
                }
                else
                {
                    front = front.next;
                }
                count -= 1;
                return rtrn;
            }
            return default(T);
        }
    }
    static class Program
    {
        static void Main()
        {
            
        }
    }
}
