using StackApp;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestStackApp
{
    public class TestsStackNode
    {
        private Stack node;

        [SetUp]
        public void SetUp()
        {
            node = new Stack();
            node.Push(0);
            node.Push(2);
            node.Push(100);
            node.Push(21);
            node.Push(79);
        }

        [Test]
        public void TestPushNode()
        {
            List<int> actual = node.GetAllNodes().Select(n => n.Data).ToList();
            List<int> expected = new List<int> { 79, 21, 100, 2, 0 };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestPopNode()
        {
            node.Pop(); // Removes 79
            node.Pop(); // Removes 21
            List<int> actual = node.GetAllNodes().Select(n => n.Data).ToList();
            List<int> expected = new List<int> { 100, 2, 0 };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestFreeNode()
        {
            node.FreeStack();
            Assert.That(node.IsEmpty, Is.True);
        }
    }

    public class TestsStackArray
    {
        private StackArray array;

        [SetUp]
        public void SetUp()
        {
            array = new StackArray();
            StackArray.InsertTopElement(0);
            StackArray.InsertTopElement(2);
            StackArray.InsertTopElement(100);
            StackArray.InsertTopElement(21);
            StackArray.InsertTopElement(79);
        }

        [Test]
        public void TestPushArray()
        {

            List<int> expected = new List<int> { 79, 21, 100, 2, 0 };
            List<int> actual = StackArray.GetStackItems().Select(n => n.Data).ToList();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestPopArray()
        {
            StackArray.DeleteTopElement(); // Removes 79
            StackArray.DeleteTopElement(); // Removes 21
            List<int> expected = new List<int> { 100, 2, 0 };
            List<int> actual = StackArray.GetStackItems().Select(n => n.Data).ToList();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestFreeArray()
        {   
            StackArray.ClearsStack();
            bool actual = StackArray.FillmentCheck();
            Assert.That(actual, Is.True);
        }
    }
}
