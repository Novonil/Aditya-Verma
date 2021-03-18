using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.Stack
{
	class StockSpan
	{
		public static List<int> StockSpanProblem(List<int> arr)
		{
			Stack<(int,int)> stck = new Stack<(int,int)>();
			List<int> result = new List<int>();

			for(int i = 0; i<arr.Count; i++)
			{
				if(stck.Count == 0)
				{
					result.Add(-1);
				}
				else if(stck.Count > 0 && stck.Peek().Item1 > arr[i])
				{
					result.Add(stck.Peek().Item2);
				}
				else if(stck.Count > 0 && stck.Peek().Item1 <= arr[i])
				{
					while(stck.Count > 0 && stck.Peek().Item1 <= arr[i])
					{
						stck.Pop();
					}
					if(stck.Count == 0)
					{
						result.Add(-1);
					}
					else
					{
						result.Add(stck.Peek().Item2);
					}
				}
				stck.Push((arr[i], i));
			}
			for(int i = 0; i < result.Count; i++)
			{
				result[i] = i - result[i];
			}
			return result;
		}
	}
}
