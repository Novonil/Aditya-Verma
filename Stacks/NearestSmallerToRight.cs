using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.Stack
{
	class NearestSmallerToRight
	{
		public static List<int> nearestSmallerToTheRight(List<int> arr)
		{
			Stack<int> stck = new Stack<int>();
			List<int> result = new List<int>();

			for(int i = arr.Count - 1; i>=0; i--)
			{
				if(stck.Count == 0)
				{
					result.Add(-1);
				}
				else if(stck.Count > 0 && stck.Peek() < arr[i])
				{
					result.Add(stck.Peek());
				}
				else if(stck.Count > 0 && stck.Peek() >= arr[i])
				{
					while(stck.Count > 0 && stck.Peek() >= arr[i])
					{
						stck.Pop();
					}
					if(stck.Count == 0)
					{
						result.Add(-1);
					}
					else
					{
						result.Add(stck.Peek());
					}
				}
				stck.Push(arr[i]);
			}
			result.Reverse();

			return result;

		}
	}
}
