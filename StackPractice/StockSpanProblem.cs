using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class StockSpanProblem
	{
		public static int[] StockSpan(List<int> stockPrices)
		{
			int K = 0;
			int n = stockPrices.Count;
			int[] result = new int[n];

			Stack<(int, int)> s = new Stack<(int, int)>();

			for(int i = 0; i < n; i++)
			{
				while(s.Count > 0 && s.Peek().Item1 <= stockPrices[i])
				{
					s.Pop();
				}
				if (s.Count == 0)
				{
					result[K++] = i + 1;
				}
				else
				{
					result[K++] = i - s.Peek().Item2;
				}
				s.Push((stockPrices[i], i));
			}
			return result;
		}
	}
}
