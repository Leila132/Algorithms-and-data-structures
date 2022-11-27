using NUnit.Framework;
using Stack;

namespace StackTests
{
    public class Tests
    {
        [Test]
        public void Push_FirstElement_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Assert.AreEqual(1, stack.GetUp());
            Assert.AreEqual(1, stack.GetDown());
            Assert.AreEqual(1, stack.GetCount());
        }
        [Test]
        public void Push_SecondElement_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.GetUp());
            Assert.AreEqual(1, stack.GetDown());
            Assert.AreEqual(2, stack.GetCount());
        }
        [Test]
        public void Push_ThirdElement_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.GetUp());
            Assert.AreEqual(1, stack.GetDown());
            Assert.AreEqual(3, stack.GetCount());
        }
        [Test]
        public void Pop_OneElementQueue_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            int a = stack.Pop();
            Assert.AreEqual(0, stack.GetUp());
            Assert.AreEqual(0, stack.GetDown());
            Assert.AreEqual(0, stack.GetCount());
            Assert.AreEqual(1, a);
        }
        [Test]
        public void Pop_TwoElementQueue_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            int a = stack.Pop();
            Assert.AreEqual(1, stack.GetUp());
            Assert.AreEqual(1, stack.GetDown());
            Assert.AreEqual(1, stack.GetCount());
            Assert.AreEqual(2, a);
        }
        [Test]
        public void Pop_ThreeElement_Test()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int a = stack.Pop();
            int b = stack.Pop();
            Assert.AreEqual(1, stack.GetUp());
            Assert.AreEqual(1, stack.GetDown());
            Assert.AreEqual(1, stack.GetCount());
            Assert.AreEqual(3, a);
            Assert.AreEqual(2, b);
        }
        [Test]
        public void Pop_NullQueue_Test()
        {
            Stack<int> stack = new Stack<int>();
            int a = stack.Pop();
            Assert.AreEqual(0, stack.GetUp());
            Assert.AreEqual(0, stack.GetDown());
            Assert.AreEqual(0, stack.GetCount());
            Assert.AreEqual(0, a);
        }
    }
}