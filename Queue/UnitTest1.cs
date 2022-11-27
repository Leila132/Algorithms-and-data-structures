using NUnit.Framework;
using Queue;
using System;

namespace QueueTest
{
    public class Tests
    {
        
        [Test]
        public void Enqueue_FirstElement_Test()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.GetFront());
            Assert.AreEqual(1, queue.GetBack());
            Assert.AreEqual(1, queue.GetCount());
        }
        [Test]
        public void Enqueue_SecondElement_Test()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.AreEqual(1, queue.GetFront());
            Assert.AreEqual(2, queue.GetBack());
            Assert.AreEqual(2, queue.GetCount());
        }
        [Test]
        public void Enqueue_ThirdElement_Test()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(1, queue.GetFront());
            Assert.AreEqual(3, queue.GetBack());
            Assert.AreEqual(3, queue.GetCount());
        }

        [Test]
        public void Dequeue_OneElementQueue_Test()
        {
            Queue<int> queue = new Queue<int>();
            int a = queue.Dequeue();
            Assert.AreEqual(0, queue.GetFront());
            Assert.AreEqual(0, queue.GetBack());
            Assert.AreEqual(0, queue.GetCount());
        }
        [Test]
        public void Dequeue_TwoElementQueue_Test()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            int a = queue.Dequeue();
            Assert.AreEqual(2, queue.GetFront());
            Assert.AreEqual(2, queue.GetBack());
            Assert.AreEqual(1, queue.GetCount());
        }
        [Test]
        public void Dequeue_ThreeElement_Test()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int a = queue.Dequeue();
            Assert.AreEqual(2, queue.GetFront());
            Assert.AreEqual(3, queue.GetBack());
            Assert.AreEqual(2, queue.GetCount());
        }
        [Test]
        public void Dequeue_NullQueue_Test()
        {
            Queue<int> queue = new Queue<int>();
            int a = queue.Dequeue();
            Assert.AreEqual(0, queue.GetFront());
            Assert.AreEqual(0, queue.GetBack());
            Assert.AreEqual(0, queue.GetCount());
        }
    }
}