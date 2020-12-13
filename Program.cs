using System;
using System.Collections.Generic;
using System.Reflection;

namespace LinkedList2
{
    class Program
    {
        public class Node<T>  
        {
            public T value;
            public Node<T> prev;
            public Node<T> next;
            public Node(T value)
            {
                this.value = value;
            }
        }

        public class LinkedList<T>
        {
            public Node<T> head;
            public Node<T> tail;
            public int len;
            public LinkedList()
            {
                Clear();
            }
            public void Clear()
            {
                head = null;
                tail = null;
                len = 0;
            }

            public void AddHead(Node<T> node)
            {
                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    node.next = head;
                    head.prev = node;
                    head = node;
                }
                len += 1;
            }

            public void RemoveHead() // O(1)
            {
                if (head == null) { }
                
                else
                {
                    if (len == 1)
                    {
                        head = null;
                        tail = null;
                        System.Console.WriteLine("список удалён");
                    }
                    else
                    {
                        head.next.prev = null;
                        head = head.next;
                    }
                    len -= 1;
                }
            }
            public void AddTail(Node<T> node)
            {
                if (head == null)
                {
                    head = node;
                    tail = node;

                }
                else
                {
                    tail.next = node;
                    node.prev = tail;
                    tail = node;
                }
                len += 1;
            }

            public void RemoveTail() // O(1)
            {
                if (tail == null) { }

                else
                {
                    if (len == 1)
                    {
                        head = null;
                        tail = null;
                        len -= 1;
                        System.Console.WriteLine("список удалён");
                    }
                    else
                    {
                        tail.prev.next = null;
                        tail = tail.prev;
                        len -= 1;
                    }
                }
            }

            public void Remove(Node<T> node) // лежит ли node в нашем списке? 
            {
                Node<T> curr = head;
                while (curr != null)
                {
                    if (curr == node)
                    {
                        if (curr == head)
                        {
                            RemoveHead();
                        }
                        else
                        {
                            if (curr == tail)
                            {
                                RemoveTail();
                            }
                            else
                            {
                                curr.prev.next = curr.next;
                                curr.next.prev = curr.prev;
                                len -= 1;
                            }
                        }
                        
                    }
                    
                    curr = curr.next;
                }
            }
            
            public void RemoveByValue2(object vvalue)
            {
                Node<T> curr = head;
                /*Type t = vvalue.GetType();
                if (IsEqualTo(t, curr.value))
                {*/
                while (curr != null)
                    {
                        object d = curr.value;
                        if (d.Equals(vvalue))
                        {
                            Remove(curr);
                            len -= 1;
                            break;
                        } 
                        curr = curr.next;
                    }
                /*}
                else System.Console.WriteLine("Неправильный тип данных.");*/

            }

            public static bool IsEqualTo(Type t, object h)
            {
                Type t2 = h as Type;
                if (t.Equals(t2))
                    return true;
                else return false; 
            }

            public Node<T> GetTail()
            {
                return tail;
            }

            public Node<T> GetHead()
            {
                return head;
            }
            public int GetLen()
            {
                return len;
            }

            public void RemoveByValueAll2(object vvalue)
            {
                /*Type t = vvalue.GetType();*/
                Node<T> curr = head;
                /*if (IsEqualTo(t, curr.value))
                {*/
                    while (curr != null)
                    {
                        object d = curr.value;
                        if (d.Equals(vvalue))
                        {
                            Remove(curr);
                            len -= 1;
                        }
                        curr = curr.next;
                    }
                /*}
                else System.Console.WriteLine("Неправильный тип данных.");*/

            }

            public void AddAfter(Node<T> nodeAfter, Node<T> nodeToInsert)
            {
                Node<T> curr = head;
                while (curr != null)
                {
                    if (curr == nodeAfter)
                    {
                        nodeToInsert.prev = curr;
                        nodeToInsert.next = curr.next;
                        curr.next.prev = nodeToInsert;
                        curr.next = nodeToInsert;
                        len += 1;
                        break;
                    }
                    curr = curr.next;
                }
            }

        }
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddHead(new Node<int>(5));
            list.AddHead(new Node<int>(4));
            list.AddHead(new Node<int>(3));

            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine(list.head.next.value);
            System.Console.WriteLine(list.head.next.next.value);

            System.Console.WriteLine("Проверка функции удаления первого элемента:");
            System.Console.WriteLine("Удаление:");
            list.RemoveHead();
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine(list.head.next.value);
            System.Console.WriteLine("Удаление:");
            list.RemoveHead();
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine("Удаление:");
            list.RemoveHead();
            list.RemoveHead();

            list.AddHead(new Node<int>(3));
            list.AddTail(new Node<int>(4));
            list.AddTail(new Node<int>(5));
            System.Console.WriteLine("Новый список:");
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine(list.head.next.value);
            System.Console.WriteLine(list.head.next.next.value);

            System.Console.WriteLine("Проверка функции удаления последнего элемента:");
            System.Console.WriteLine("Удаление:");
            list.RemoveTail();
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine(list.head.next.value);
            System.Console.WriteLine("Удаление:");
            list.RemoveTail();
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine("Удаление:");
            list.RemoveTail();
            list.RemoveTail();

            System.Console.WriteLine("Новый список:");
            list.AddHead(new Node<int>(3));
            list.AddTail(new Node<int>(4));
            list.AddTail(new Node<int>(5));
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine(list.head.next.value);
            System.Console.WriteLine(list.head.next.next.value);

            System.Console.WriteLine("Проверка функции удаления элемента:");
            System.Console.WriteLine("Удаление list.head.next:");
            list.Remove(list.head.next);
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine(list.head.next.value);
            System.Console.WriteLine("Удаление list.head:");
            list.Remove(list.head);
            System.Console.WriteLine(list.head.value);
            System.Console.WriteLine("Удаление:");
            list.Remove(list.head);

            System.Console.WriteLine("Новый список 2:");
            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddHead(new Node<int>(3));
            list2.AddTail(new Node<int>(4));
            list2.AddTail(new Node<int>(5));
            list2.AddTail(new Node<int>(4));
            list2.AddTail(new Node<int>(5));
            System.Console.WriteLine(list2.head.value);
            System.Console.WriteLine(list2.head.next.value);
            System.Console.WriteLine(list2.head.next.next.value);
            System.Console.WriteLine(list2.head.next.next.next.value);
            System.Console.WriteLine(list2.head.next.next.next.next.value);

            System.Console.WriteLine("Удаление элемента по значению:");
            System.Console.WriteLine("Удаление 4:");
            list2.RemoveByValue2(4);
            System.Console.WriteLine(list2.head.value);
            System.Console.WriteLine(list2.head.next.value);
            System.Console.WriteLine(list2.head.next.next.value);

            System.Console.WriteLine("Новый список 3:");
            LinkedList<string> list3 = new LinkedList<string>();
            list3.AddHead(new Node<string>("яблоко"));
            list3.AddTail(new Node<string>("банан"));
            list3.AddTail(new Node<string>("яблоко"));
            list3.AddTail(new Node<string>("груша"));
            list3.AddTail(new Node<string>("банан"));
            System.Console.WriteLine(list3.head.value);
            System.Console.WriteLine(list3.head.next.value);
            System.Console.WriteLine(list3.head.next.next.value);
            System.Console.WriteLine(list3.head.next.next.next.value);
            System.Console.WriteLine(list3.head.next.next.next.next.value);

            System.Console.WriteLine("Удаление элементов по значению:");
            System.Console.WriteLine("Удаление яблока:");
            list3.RemoveByValue2("яблоко");
            System.Console.WriteLine(list3.head.value);
            System.Console.WriteLine(list3.head.next.value);
            System.Console.WriteLine(list3.head.next.next.value);

            System.Console.WriteLine("Удаление по GetHead:");
            list3.Remove(list3.GetHead());
            System.Console.WriteLine(list3.head.value);

            System.Console.WriteLine("Добавление элементов после:");
            list3.AddAfter(list3.GetHead(), new Node<string>("апельсин"));
            System.Console.WriteLine(list3.head.value);
            System.Console.WriteLine(list3.head.next.value);
        }
    }
}
