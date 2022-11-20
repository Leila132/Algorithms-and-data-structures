using NUnit.Framework;
using Stack;

namespace StackTests
{
    public class Tests
    {
        [Test]
        public void Push_FirstElement_Test()
        {
            Node<int> node = new Node<int>(5);
            Stack<int> stack = new Stack<int>();
            stack.Push(node);
            Assert.AreEqual(node, stack.GetUp());
            Assert.AreEqual(node, stack.GetDown());
            Assert.AreEqual(1, stack.GetCount());
        }
        [Test]
        public void Push_SecondElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Stack<int> stack = new Stack<int>();
            stack.Push(node1);
            stack.Push(node2);
            Assert.AreEqual(node2, stack.GetUp());
            Assert.AreEqual(node1, stack.GetDown());
            Assert.AreEqual(2, stack.GetCount());
        }
        [Test]
        public void Push_ThirdElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Stack<int> stack = new Stack<int>();
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            Assert.AreEqual(node3, stack.GetUp());
            Assert.AreEqual(node1, stack.GetDown());
            Assert.AreEqual(3, stack.GetCount());
        }
        [Test]
        public void Push_AddedElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Stack<int> stack = new Stack<int>();
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node2);
            Assert.AreEqual(node2, stack.GetUp());
            Assert.AreEqual(node1, stack.GetDown());
            Assert.AreEqual(2, stack.GetCount());
        }

        [Test]
        public void Pop_OneElementQueue_Test()
        {
            Stack<int> stack = new Stack<int>();
            Node<int> node1 = new Node<int>(1);
            stack.Push(node1);
            stack.Pop();
            Assert.AreEqual(null, stack.GetUp());
            Assert.AreEqual(null, stack.GetDown());
            Assert.AreEqual(0, stack.GetCount());
        }
        [Test]
        public void Pop_TwoElementQueue_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Stack<int> stack = new Stack<int>();
            stack.Push(node1);
            stack.Push(node2);
            stack.Pop();
            Assert.AreEqual(node1, stack.GetUp());
            Assert.AreEqual(node1, stack.GetDown());
            Assert.AreEqual(1, stack.GetCount());
        }
        [Test]
        public void Pop_ThreeElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Stack<int> stack = new Stack<int>();
            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.Pop();
            Assert.AreEqual(node2, stack.GetUp());
            Assert.AreEqual(node1, stack.GetDown());
            Assert.AreEqual(2, stack.GetCount());
        }
        [Test]
        public void Pop_NullQueue_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();
            Assert.AreEqual(null, stack.GetUp());
            Assert.AreEqual(null, stack.GetDown());
            Assert.AreEqual(0, stack.GetCount());
        }
    }
}