using AdityaVerma.SlidingWindow;
using AdityaVerma.Stack;
using AdityaVerma.StackPractice;
using System;
using System.Collections.Generic;

namespace AdityaVerma
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			StackPractice.MinStackConstantSpace m = new StackPractice.MinStackConstantSpace();
			m.Push(5);
			n = m.Peek();
			n = m.min();
			m.Push(7);
			n = m.Peek();
			n = m.min();
			m.Push(2);
			n = m.Peek();
			n = m.min();
			n = m.Pop();
			n = m.Peek();
			n = m.min();
			n = m.Pop();
			n = m.Peek();
			n = m.min();
			m.Push(1);
			n = m.Peek();
			n = m.min();
			Console.Read();
		}
	}
}
