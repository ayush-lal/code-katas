using System;
namespace TDD_LinkedListTests
{
	public class MyLinkedList
	{
		public ListNode Tail { get; set; }
		public ListNode Head { get; set; }
		public int Count { get; set; }

		public void AddFirst(int value)
        {
			AddFirst(new ListNode(value));
        }

		private void AddFirst(ListNode node)
        {
			ListNode temp = Head;

			Head = node;

			Head.Next = temp;

			Count++;

			if (Count == 1)
            {
				Tail = Head;
            }
        }

		public void AddLast(int value)
        {
			AddLast(new ListNode(value));
        }

		private void AddLast(ListNode node)
        {
			if (Count == 0)
            {
				Head = node;
            }
			else
            {
				Tail.Next = node;
            }

			Tail = node;

			Count++;
        }

		public void RemoveFirst()
        {
			if (Count == 0)
            {
				throw new InvalidOperationException();
            }
        }
	}
}

