using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class NearestSmallerToLeft
	{
		public static int[] NearestSmallerElementToLeft(List<int> arr)
		{
			int k = 0;
			int n = arr.Count;
			int[] result = new int[n];
			Stack<int> s = new Stack<int>();

			for(int i = 0; i < n; i++)
			{
				while(s.Count > 0 && s.Peek() >= arr[i])
				{
					s.Pop();
				}
				if(s.Count == 0)
				{
					result[k++] = -1;
				}
				else
				{
					result[k++] = s.Peek();
				}
				s.Push(arr[i]);
			}
			return result;
		}
	}
}
