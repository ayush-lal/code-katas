using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDD_StackTests
{
    [TestFixture]
    public class StackTests
    {
        private MyStack stack;

        [SetUp]
        public void Setup()
        {
            stack = new MyStack();
        }

        [Test]
        public void GivenEmptyStack_ThenReturnTrue()
        {
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void GivenEmptyStack_WhenPush_ThenReturnOne()
        {
            stack.Push(1);

            Assert.AreEqual(1, stack.count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void GivenEmptyStack_WhenPop_ThenThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                stack.Pop();
            });
        }

        [Test]
        public void GivenStack_WhenPeep_ThenReturnHeadItem()
        {
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peep());
        }

        [Test]
        public void GivenStack_WhenPushAndPop_ThenReturnHeadItem()
        {
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peep());
        }
    }

    public class MyStack
    {
        private List<int> list = new List<int>();

        public int count => list.Count;

        public bool IsEmpty => count == 0;

        public void Push(int value)
        {
            list.Add(value);
        }

        public void Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {
                list.RemoveAt(count - 1);
            }
        }

        public int Peep()
        {
            return list[count - 1]; 
        }
    }
}