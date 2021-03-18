using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.Stack
{
	class NearestSmallerToLeft
	{
		public static List<int> nearestSmallerToTheLeft(List<int> arr)
		{
			Stack<int> stck = new Stack<int>();
			List<int> result = new List<int>();

			for(int i = 0; i < arr.Count; i++)
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
			return result;
		}
	}
}
