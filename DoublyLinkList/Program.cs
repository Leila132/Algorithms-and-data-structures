using System;

namespace DoublyLinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.value = value;
            next = null;
            prev = null;
        }
        public T value;
        public Node<T> next;
        public Node<T> prev;
    }

    public class DoublyLinkedList<T>
    {
        private int count = 0;
        private Node<T> head;
        private Node<T> tail;
        public int GetCount()
        {
            return count;
        }
        public Node<T> GetTail()
        {
            return tail;
        }
        public Node<T> GetHead()
        {
            return head;
        }
        public void Print()
        {
            string values = "";
            Node<T> start = head;
            while (start != null)
            {
                values += start.value.ToString() + " ";
                start = start.next;
            }
            Console.WriteLine(values);
        }
        private Node<T> FindNode(Node<T> x)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Equals(x))
                {
                    return current;
                }
                else
                {
                    current = current.next;
                }
            }
            return null;
        }
        public void AddTail(Node<T> x)
        {
            if (FindNode(x) == null)
            {
                if (count == 0)
                {
                    head = x;
                    tail = x;
                }
                else
                {
                    tail.next = x;
                    x.prev = tail;
                    tail = x;
                }
                count += 1;
            }
        }

        public void AddHead(Node<T> x)
        {
            if (FindNode(x) == null)
            {
                if (count == 0)
                {
                    head = x;
                    tail = x;
                }
                else
                {
                    head.prev = x;
                    x.next = head;
                    head = x;
                }
                count += 1;
            }
        }
        public void AddAfter(Node<T> after, Node<T> nodeToInsert)
        {
            if (FindNode(nodeToInsert) == null && FindNode(after) == after)
            {
                if (after != tail)
                {
                    nodeToInsert.next = after.next;
                    after.next.prev = nodeToInsert;
                    nodeToInsert.prev = after;
                    after.next = nodeToInsert;
                }
                else
                {
                    after.next = nodeToInsert;
                    nodeToInsert.prev = after;
                    tail = nodeToInsert;
                }
                count += 1;
            }
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        private Node<T> FindNodeBeforeCurrent(Node<T> x)
        {
            Node<T> current = head;
            Node<T> node_before_current = null;
            while (current != null)
            {
                if (current.next != x)
                {
                    current = current.next;
                }
                else
                {
                    node_before_current = current;
                    break;
                }
            }
            return node_before_current;
        }
        public void RemoveNode(Node<T> x)
        {
            Node<T> current = head;
            if (current == x)
            {
                head = current.next;
                if (head != null)
                { head.prev = null; }
                else { tail = null; }
                count -= 1;
            }
            else
            {
                Node<T> after = FindNodeBeforeCurrent(x);
                if (after != null)
                {
                    if (x == tail) { after.next = null; tail = after; }
                    else
                    {
                        after.next = x.next;
                        after.next.prev = after;
                    }
                    count -= 1;
                }
            }
        }

        public Node<T> FindByValue(T val)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(val))
                {
                    return current;
                }
                else
                {
                    current = current.next;
                }
            }
            return null;
        }
        public void RemoveByValue(T x)
        {
            Node<T> node = FindByValue(x);
            if (node != null)
            {
                RemoveNode(node);
            }
        }
        public void RemoveAllByValue(T x)
        {
            while(FindByValue(x) != null)
            {
                RemoveByValue(x);
            }
        }
    }

}
