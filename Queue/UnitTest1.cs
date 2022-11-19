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
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            Assert.AreEqual(node, queue.GetFront());
            Assert.AreEqual(node, queue.GetBack());
            Assert.AreEqual(1, queue.GetCount());
        }
        [Test]
        public void Enqueue_SecondElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            Assert.AreEqual(node1, queue.GetFront());
            Assert.AreEqual(node2, queue.GetBack());
            Assert.AreEqual(2, queue.GetCount());
        }
        [Test]
        public void Enqueue_ThirdElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            Assert.AreEqual(node1, queue.GetFront());
            Assert.AreEqual(node3, queue.GetBack());
            Assert.AreEqual(3, queue.GetCount());
        }
        [Test]
        public void Enqueue_AddedElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node2);
            Assert.AreEqual(node1, queue.GetFront());
            Assert.AreEqual(node2, queue.GetBack());
            Assert.AreEqual(2, queue.GetCount());
        }

        [Test]
        public void Dequeue_OneElementQueue_Test()
        {
            Node<int> node = new Node<int>(5);
            Queue<int> queue = new Queue<int>();
            queue.Dequeue();
            Assert.AreEqual(null, queue.GetFront());
            Assert.AreEqual(null, queue.GetBack());
            Assert.AreEqual(0, queue.GetCount());
        }
        [Test]
        public void Dequeue_TwoElementQueue_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Dequeue();
            Assert.AreEqual(node2, queue.GetFront());
            Assert.AreEqual(node2, queue.GetBack());
            Assert.AreEqual(1, queue.GetCount());
        }
        [Test]
        public void Dequeue_ThreeElement_Test()
        {
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Dequeue();
            Assert.AreEqual(node2, queue.GetFront());
            Assert.AreEqual(node3, queue.GetBack());
            Assert.AreEqual(2, queue.GetCount());
        }
        [Test]
        public void Dequeue_NullQueue_Test()
        {
            Queue<int> queue = new Queue<int>();
            queue.Dequeue();
            Assert.AreEqual(null, queue.GetFront());
            Assert.AreEqual(null, queue.GetBack());
            Assert.AreEqual(0, queue.GetCount());
        }
    }
}