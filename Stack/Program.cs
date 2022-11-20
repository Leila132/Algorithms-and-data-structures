using System;

namespace Stack
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
    public class Stack<T>
    {
        private Node<T> up;
        private Node<T> down;
        private int count = 0;

        public Node<T> GetUp()
        {
            return up;
        }
        public Node<T> GetDown()
        {
            return down;
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
        private bool FindNode(Node<T> x)
        {
            Node<T> current = up;
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
        public void Push(Node<T> x)
        {
            if (!FindNode(x))
            {
                if (count == 0)
                {
                    up = x;
                    down = x;
                }
                else
                {
                    x.next = up;
                    up = x;
                }
                count += 1;
            }
        }
        public void Pop()
        {
            if (count != 0)
            {
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
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
