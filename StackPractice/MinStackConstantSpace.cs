using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class MinStackConstantSpace
	{
		int minimum;
		Stack<int> s = new Stack<int>();
		public void Push(int x)
		{
			if (s.Count == 0)
			{
				minimum = x;
				s.Push(x);
			}
				
			else if (x < minimum)
			{
				s.Push(2 * x - minimum);
				minimum = x;
			}
			else
			{
				s.Push(x);
			}
			
		}
		public int Pop()
		{
			int num;

			if (s.Peek() < minimum)
			{
				num = minimum;
				minimum = 2 * minimum - s.Pop();
				return num;
			}
			return s.Pop();
		}
		public int Peek()
		{
			if(s.Count == 0)
			{ 
				return -1;
			}
			else if(s.Peek() < minimum)
			{
				return minimum;
			}
			return s.Peek();
		}
		public int min()
		{
			if (s.Count == 0)
				return -1;
			return minimum;
		}
	}
}
