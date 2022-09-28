using System;

namespace linkedListt
{
    public class Node
    {
        public Node(int value)
        {
            this.value = value;
            next = null;
        }

        public int value;
        public Node next;
    }

    public class LinkedList
    {
        private int count = 0;
        private Node head;
        private Node tail;

        public int GetCount()
        {
            return count;
        }

        public Node GetTail()
        {
            return tail;
        }
        public Node GetHead()
        {
            return head;
        }

        public void Print()
        {
            string values = "";
            Node start = head;
            while (start != null)
            {
                values += start.value + " ";
                start = start.next;
            }
            Console.WriteLine(values);
        }

        public void AddTail(Node x)
        {
            if (count == 0)
            {
                head = x;
                tail = x;
                count += 1;
            }
            else
            {
                if (count == 1)
                {
                    tail = x;
                    head.next = tail;
                }
                else
                {
                    tail.next = x;
                    tail = x;
                }
                count += 1;
            }
        }

        public void AddHead(Node x)
        {
            if (count == 0)
            {
                head = x;
                tail = x;
            }
            else
            {
                if (count == 1)
                {
                    head = x;
                    head.next = tail;
                }
                else
                {
                    x.next = head;
                    head = x;
                }
            }
            count += 1;
        }

        public void AddAfter(Node after, Node nodeToInsert)
        {
            bool flag = false;
            Node current = head;
            while (current != null)
            {
                flag = flag || current == after;
                if (flag == true) { break; }
                current = current.next;
            }
            if (current != null)
            {
                nodeToInsert.next = current.next;
                current.next = nodeToInsert;
                if (current == tail) { tail = nodeToInsert; }
                count += 1;
            }
            
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        private Node FindNodeBeforeCurrent(Node x)
        {
            Node current = head;
            Node node_before_current = null;
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
        public void RemoveNode(Node x)
        {
            Node current = head;
            if (current == x)
            {
                head = current.next;
                count -= 1;
            }
            else
            {
                Node finish = FindNodeBeforeCurrent(x);
                if (finish != null)
                {
                    finish.next = finish.next.next;
                    if (finish.next == null) { tail = finish; }
                    count -= 1;
                }
            }
        }

        public void RemoveByValue(int val)
        {
            Node current = head;
            if (current.value == val)
            {
                head = current.next;
                count -= 1;
            }
            else
            {
                int i = 0;
                Node before = null;
                while (i < count)
                {
                    if (current.next.value != val)
                    {
                        current = current.next;
                        i += 1;
                    }
                    else
                    {
                        before = current;
                        break;
                    }
                }
                if (before != null)
                {
                    before.next = before.next.next;
                    if (before.next == null) { tail = before; }
                    count -= 1;
                }
            }
        }

       

        public void RemoveAllByValue(int val)
        {
            Node counter_before = head;
            Node counter_present = head.next;
            int i = 0;
            int cc = count;
            while (i < cc)
            {
                if (counter_before.value == val && counter_before == head)
                {
                    head = counter_present;
                    counter_before = head;
                    if (head == null)
                    {
                        tail = null;
                        count = 0;
                        break;
                    }
                    else
                    {
                        counter_present = head.next;

                        count -= 1;
                        i += 1;
                    }
                }
                else
                {
                    if (counter_before == tail)
                    {
                        break;
                    }
                    else
                    {
                        if (counter_present.value == val)
                        {
                            if (counter_present == tail)
                            {
                                counter_before.next = null;
                                tail = counter_before;
                                count -= 1;
                                break;
                            }
                            else
                            {
                                counter_before.next = counter_present.next;
                                counter_present = counter_before.next;
                                count -= 1;

                            }
                        }
                        else
                        {
                            counter_before = counter_before.next;
                            counter_present = counter_present.next;
                            i += 1;
                        }
                    }
                }
            }
        }

        public Node FindByValue(int val)
        {
            Node current = head;
            while (current != null)
            {
                if (current.value == val) {
                    return current; 
                }
                else
                {
                    current = current.next;
                }
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node k = new Node(1);
            Node ka = new Node(2);
            Node h = new Node(3);
            Node r = new Node(4);
            Node a = new Node(5);
            Node p = new Node(6);
            LinkedList l = new LinkedList();
            l.AddTail(k);
            l.AddTail(ka);
            l.AddTail(h);
            l.AddAfter(p,r);
            l.AddTail(p);
            l.Print();
            l.RemoveNode(p);
            l.Print();
            Console.WriteLine("Count: " + l.GetCount());
        }
    }
}
