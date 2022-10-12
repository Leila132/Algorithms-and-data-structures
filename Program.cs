using System;

namespace linkedListt
{
    public class Node<T>
    {
        public Node(T value)
        {
            this.value = value;
            next = null;
        }

        public T value;
        public Node<T> next;
    }

    public class LinkedList<T>
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
                values += start.value + " ";
                start = start.next;
            }
            Console.WriteLine(values);
        }

        public void AddTail(Node<T> x)
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

        public void AddHead(Node<T> x)
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

        public void AddAfter(Node<T> after, Node<T> nodeToInsert)
        {
            bool flag = false;
            Node<T> current = head;
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
                count -= 1;
            }
            else
            {
                Node<T> finish = FindNodeBeforeCurrent(x);
                if (finish != null)
                {
                    finish.next = finish.next.next;
                    if (finish.next == null) { tail = finish; }
                    count -= 1;
                }
            }
        }

        public void RemoveByValue(T val)
        {
            Node<T> current = head;
            if (current.value.Equals(val))
            {
                head = current.next;
                count -= 1;
            }
            else
            {
                int i = 0;
                Node<T> before = null;
                while (i < count)
                {
                    if (current.next != null)
                    {
                        if (current.next.value.Equals(val))
                        {
                            before = current;
                            Console.WriteLine("find");
                            break;
                        }
                        else
                        {
                            current = current.next;
                            i += 1;
                        }
                    }
                    else
                    {
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

       

        public void RemoveAllByValue(T val)
        {
            Node<T> counter_before = head;
            Node<T> counter_present = head.next;
            int i = 0;
            int cc = count;
            while (i < cc)
            {
                if (counter_before.value.Equals(val) && counter_before == head)
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
                        if (counter_present.value.Equals(val))
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

        public Node<T> FindByValue(T val)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(val)) {
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
            /*Node<string> k = new Node<string>("a");
            Node<string> ka = new Node<string>("a");
            Node<string> h = new Node<string>("a");
            Node<string> r = new Node<string>("a");
            LinkedList<string> l = new LinkedList<string>();
            l.AddTail(k);
            l.AddTail(ka);
            l.AddTail(h);
            l.AddTail(r);
            l.Print();
            l.RemoveAllByValue("a");
            l.Print();
            Console.WriteLine("Count: " + l.GetCount());*/
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_one);
            linklist.RemoveNode(node_one);
            linklist.Print();
        }
    }
}
