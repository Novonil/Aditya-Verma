using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class MinStack
	{
		Stack<int> s = new Stack<int>();
		Stack<int> min = new Stack<int>();

		public void push(int x)
		{
			s.Push(x);
			if(min.Count == 0)
			{
				min.Push(x);
			}
			else if(min.Peek() >= x)
			{
				min.Push(x);
			}
		}
		public int pop()
		{
			if(s.Peek() == min.Peek())
			{
				min.Pop();
				return s.Pop();
			}
			return s.Pop();
		}
		public int minElement()
		{
			if (min.Count == 0)
				return -1;
			return min.Peek();
		}
		public int peek()
		{
			if (s.Count == 0)
				return -1;
			return s.Peek();
		}
	}
}
