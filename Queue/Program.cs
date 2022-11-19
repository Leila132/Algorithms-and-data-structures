using System;

namespace Queue
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
    public class Queue<T>
    {
        private Node<T> front;
        private Node<T> back;
        private int count = 0;

        public Node<T> GetFront()
        {
            return front;
        }
        public Node<T> GetBack()
        {
            return back;
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
        private bool FindNode(Node<T> x)
        {
            Node<T> current = front;
            while (current != null)
            {
                if (current.Equals(x))
                {
                    return true;
                }
                else
                {
                    current = current.next;
                }
            }
            return false;
        }
        public void Enqueue(Node<T> x)
        {
            if (!FindNode(x))
            {
                if (count == 0)
                {
                    front = x;
                    back = x;
                }
                else
                {
                    back.next = x;
                    back = x;
                }
                count += 1;
            }
        }
        public void Dequeue()
        {
            if (count != 0)
            {
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
            }
        }
    }
    static class Program
    {
        static void Main()
        {
            
        }
    }
}
