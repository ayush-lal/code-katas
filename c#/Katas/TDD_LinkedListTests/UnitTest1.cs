using System;
using NUnit.Framework;

namespace TDD_LinkedListTests
{
    [TestFixture]
    public class TDD_LinkedListTests
    {
        private MyLinkedList list;

        [SetUp]
        public void Setup()
        {
            list = new MyLinkedList();
        }

        [Test]
        public void GivenNode_WhenValueSet_ThenSetsValueAndNextIsNull()
        {
            ListNode node = new ListNode(1);

            Assert.AreEqual(1, node.Value);
            Assert.IsNull(node.Next);
        }

        [Test]
        public void GivenNode_WhenFirstElementAddition_ThenHeadAndTailMatch()
        {
            list.AddFirst(1);

            Assert.AreEqual(1, list.Tail.Value);
            Assert.AreEqual(1, list.Head.Value);
            Assert.AreSame(list.Head, list.Tail);
        }

        [Test]
        public void GivenNode_WhenFirstTwoElementAddition_ThenListIsInCorrectState()
        {
            list.AddFirst(1);
            list.AddFirst(2);

            Assert.AreEqual(1, list.Tail.Value);
            Assert.AreEqual(2, list.Head.Value);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(list.Head.Next, list.Tail);
        }

        [Test]
        public void GivenNode_WhenLastElementAddition_ThenHeadAndTailMatch()
        {
            list.AddLast(1);

            Assert.AreEqual(1, list.Tail.Value);
            Assert.AreEqual(1, list.Head.Value);
            Assert.AreSame(list.Head, list.Tail);
        }

        [Test]
        public void GivenNode_WhenLastTwoElementAddition_ThenListIsInCorrectState()
        {
            list.AddLast(1);
            list.AddLast(2);

            Assert.AreEqual(1, list.Head.Value);
            Assert.AreEqual(2, list.Tail.Value);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(list.Head.Next, list.Tail);
        }

        [Test]
        public void GivenEmptyList_WhenFirstElementRemoved_ThenThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                list.RemoveFirst();
            });
        }
    }
}