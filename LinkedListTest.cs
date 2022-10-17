using linkedListt;
using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    public class LinkedListTest
    {
        ///AddTail
        [Test]
        public void Add_Tail_For_null_List_Get_Tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node = new Node<string>("first");
            linklist.AddTail(node);
            Assert.AreEqual(node, linklist.GetTail());
        }
        [Test]
        public void Add_Tail_For_null_List_Get_Head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node = new Node<string>("first");
            linklist.AddTail(node);
            Assert.AreEqual(node, linklist.GetHead());
        }
        [Test]
        public void Add_Tail_For_one_elem_List_Get_Tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            Assert.AreEqual(node_two, linklist.GetTail());
        }
        [Test]
        public void Add_Tail_For_one_elem_List_Get_Head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            Assert.AreEqual(node_one, linklist.GetHead());
        }
        [Test]
        public void Add_Tail_For_more_elem_List_Get_Tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            Assert.AreEqual(node_three, linklist.GetTail());
        }

        ///AddHead
        [Test]
        public void Add_Head_For_null_List_Get_Head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node = new Node<string>("first");
            linklist.AddHead(node);
            Assert.AreEqual(node, linklist.GetHead());
        }
        [Test]
        public void Add_Head_For_null_List_Get_Tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node = new Node<string>("first");
            linklist.AddHead(node);
            Assert.AreEqual(node, linklist.GetTail());
        }
        [Test]
        public void Add_Head_For_one_elem_List_Get_Head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddHead(node_one);
            linklist.AddHead(node_two);
            Assert.AreEqual(node_two, linklist.GetHead());
        }
        [Test]
        public void Add_Head_For_one_elem_List_Get_Tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddHead(node_one);
            linklist.AddHead(node_two);
            Assert.AreEqual(node_one, linklist.GetTail());
        }
        [Test]
        public void Add_Head_For_more_elem_List_Get_Head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddHead(node_one);
            linklist.AddHead(node_two);
            linklist.AddHead(node_three);
            Assert.AreEqual(node_three, linklist.GetHead());
        }

        ///AddAfter
       [Test]
        public void AddAfter_for_mid_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_three);
            linklist.AddAfter(node_one, node_two);
            Assert.AreEqual(node_two, linklist.GetHead().next);
        }
        [Test]
        public void AddAfter_for_tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddAfter(node_two, node_three);
            Assert.AreEqual(node_three, linklist.GetTail());
        }
        [Test]
        public void AddAfter_nullNode_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddAfter(node_two, node_three);
            Assert.AreEqual(null, linklist.GetHead().next);
        }

        ///Clear
        [Test]
        public void Clear_GetHead_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.Clear();
            Assert.AreEqual(null, linklist.GetHead());
        }
        [Test]
        public void Clear_GetTail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.Clear();
            Assert.AreEqual(null, linklist.GetTail());
        }

        ///RemoveNode
        [Test]
        public void RemoveNode_head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveNode(node_one);
            Assert.AreEqual(node_two, linklist.GetHead());
            Assert.AreEqual(node_two, linklist.GetTail());
        }
        [Test]
        public void RemoveNode_mid_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveNode(node_two);
            Assert.AreEqual(node_three, linklist.GetHead().next);
        }
        [Test]
        public void RemoveNode_tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveNode(node_three);
            Assert.AreEqual(node_two, linklist.GetTail());
        }
        [Test]
        public void RemoveNode_null_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveNode(node_three);
            Assert.AreEqual(2, linklist.GetCount());
        }

        ///RemoveNodeByVaue
        [Test]
        public void RemoveNodeByValue_head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveByValue("first");
            Assert.AreEqual(node_two, linklist.GetHead());
            Assert.AreEqual(node_two, linklist.GetTail());
        }
        [Test]
        public void RemoveNodeByValue_mid_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveByValue("second");
            Assert.AreEqual(node_three, linklist.GetHead().next);
        }
        [Test]
        public void RemoveNodeByValue_tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveByValue("second");
            Assert.AreEqual(node_one, linklist.GetHead());
            Assert.AreEqual(node_one, linklist.GetTail());
        }
        [Test]
        public void RemoveNodeByValue_null_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveByValue("third");
            Assert.AreEqual(2, linklist.GetCount());
        }
        /// needed 1-2 more tests with duplicates: ("first", "first", "second"), delete "first". ("second", "first", "first"), delete "first".

        ///RemoveAllByValue
        [Test]
        public void RemoveAllByValue_123_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(2);
            Node<int> node_three = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1)); /// tests for FindByValue needed upper
        }
        [Test]
        public void RemoveAllByValue_213_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_231_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(3);
            Node<int> node_three = new Node<int>(1);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_1123_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(2);
            Node<int> node_four = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_1213_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(2);
            Node<int> node_three = new Node<int>(1);
            Node<int> node_four = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_2113_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(1);
            Node<int> node_four = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_2311_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(3);
            Node<int> node_three = new Node<int>(1);
            Node<int> node_four = new Node<int>(1);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_11211_2_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(2);
            Node<int> node_four = new Node<int>(1);
            Node<int> node_five = new Node<int>(1);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.AddTail(node_five);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_11211211_22_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_1 = new Node<int>(1);
            Node<int> node_2 = new Node<int>(1);
            Node<int> node_3 = new Node<int>(2);
            Node<int> node_4 = new Node<int>(1);
            Node<int> node_5 = new Node<int>(1);
            Node<int> node_6 = new Node<int>(2);
            Node<int> node_7 = new Node<int>(1);
            Node<int> node_8 = new Node<int>(1);
            linklist.AddTail(node_1);
            linklist.AddTail(node_2);
            linklist.AddTail(node_3);
            linklist.AddTail(node_4);
            linklist.AddTail(node_5);
            linklist.AddTail(node_6);
            linklist.AddTail(node_7);
            linklist.AddTail(node_8);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        [Test]
        public void RemoveAllByValue_1111_null_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_1 = new Node<int>(1);
            Node<int> node_2 = new Node<int>(1);
            Node<int> node_3 = new Node<int>(1);
            Node<int> node_4 = new Node<int>(1);
            linklist.AddTail(node_1);
            linklist.AddTail(node_2);
            linklist.AddTail(node_3);
            linklist.AddTail(node_4);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(null, linklist.FindByValue(1));
        }
        
        /// needed to check head, tail

        ///FindByValue
        [Test]
        public void FindByValue_head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            Assert.AreEqual(node_one, linklist.FindByValue("first"));
        }
        [Test]
        public void FindByValue_mid_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            Assert.AreEqual(node_two, linklist.FindByValue("second"));
        }
        [Test]
        public void FindByValue_tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            Assert.AreEqual(node_three, linklist.FindByValue("third"));
        }
        [Test]
        public void FindByValue_null_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            Assert.AreEqual(null, linklist.FindByValue("third"));
        }
        
        /// needed 2 tests: 1 - with duplicates, 2 - with list which contains 1 element.

        ///GetCount
        [Test]
        public void GetCount_AddTail_for_null_list_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            linklist.AddTail(node_one);
            Assert.AreEqual(1, linklist.GetCount());
        }
        [Test]
        public void GetCount_AddTail_for_one_elem_list_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_AddHead_for_null_list_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            linklist.AddHead(node_one);
            Assert.AreEqual(1, linklist.GetCount());
        }
        [Test]
        public void GetCount_AddHead_for_one_elem_list_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddHead(node_two);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_AddAfter_for_mid_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_three);
            linklist.AddAfter(node_one, node_two);
            Assert.AreEqual(3, linklist.GetCount());
        }
        [Test]
        public void GetCount_AddAfter_for_tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddAfter(node_two, node_three);
            Assert.AreEqual(3, linklist.GetCount());
        }
        [Test]
        public void GetCount_AddAfter_null_node_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddAfter(node_two, node_three);
            Assert.AreEqual(1, linklist.GetCount());
        }
        [Test]
        public void GetCount_Clear_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.Clear();
            Assert.AreEqual(0, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveNode_head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveNode(node_one);
            Assert.AreEqual(1, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveNode_mid_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveNode(node_two);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveNode_tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveNode(node_three);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveNodeByValue_head_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveByValue("first");
            Assert.AreEqual(1, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveNodeByValue_mid_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            Node<string> node_three = new Node<string>("third");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveByValue("second");
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveNodeByValue_tail_Test()
        {
            LinkedList<string> linklist = new LinkedList<string>();
            Node<string> node_one = new Node<string>("first");
            Node<string> node_two = new Node<string>("second");
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.RemoveByValue("second");
            Assert.AreEqual(1, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_123_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(2);
            Node<int> node_three = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_213_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_231_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(3);
            Node<int> node_three = new Node<int>(1);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_1123_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(2);
            Node<int> node_four = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_1213_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(2);
            Node<int> node_three = new Node<int>(1);
            Node<int> node_four = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_2113_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(1);
            Node<int> node_four = new Node<int>(3);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_2311_23_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(2);
            Node<int> node_two = new Node<int>(3);
            Node<int> node_three = new Node<int>(1);
            Node<int> node_four = new Node<int>(1);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_11211_2_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_one = new Node<int>(1);
            Node<int> node_two = new Node<int>(1);
            Node<int> node_three = new Node<int>(2);
            Node<int> node_four = new Node<int>(1);
            Node<int> node_five = new Node<int>(1);
            linklist.AddTail(node_one);
            linklist.AddTail(node_two);
            linklist.AddTail(node_three);
            linklist.AddTail(node_four);
            linklist.AddTail(node_five);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(1, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_11211211_22_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_1 = new Node<int>(1);
            Node<int> node_2 = new Node<int>(1);
            Node<int> node_3 = new Node<int>(2);
            Node<int> node_4 = new Node<int>(1);
            Node<int> node_5 = new Node<int>(1);
            Node<int> node_6 = new Node<int>(2);
            Node<int> node_7 = new Node<int>(1);
            Node<int> node_8 = new Node<int>(1);
            linklist.AddTail(node_1);
            linklist.AddTail(node_2);
            linklist.AddTail(node_3);
            linklist.AddTail(node_4);
            linklist.AddTail(node_5);
            linklist.AddTail(node_6);
            linklist.AddTail(node_7);
            linklist.AddTail(node_8);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(2, linklist.GetCount());
        }
        [Test]
        public void GetCount_RemoveAllByValue_1111_null_Test()
        {
            LinkedList<int> linklist = new LinkedList<int>();
            Node<int> node_1 = new Node<int>(1);
            Node<int> node_2 = new Node<int>(1);
            Node<int> node_3 = new Node<int>(1);
            Node<int> node_4 = new Node<int>(1);
            linklist.AddTail(node_1);
            linklist.AddTail(node_2);
            linklist.AddTail(node_3);
            linklist.AddTail(node_4);
            linklist.RemoveAllByValue(1);
            Assert.AreEqual(0, linklist.GetCount());
        }
    }
}
