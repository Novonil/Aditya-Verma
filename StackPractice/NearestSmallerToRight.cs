using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class NearestSmallerToRight
	{
		public static int[] NearestSmallerElementToRight(List<int> arr)
		{
			int n = arr.Count;
			int K = n - 1;
			int[] result = new int[n];
			Stack<int> s = new Stack<int>();

			for(int i = n-1; i>=0; i--)
			{
				while(s.Count > 0 && s.Peek() >= arr[i])
				{
					s.Pop();
				}
				if(s.Count == 0)
				{
					result[K--] = -1;
				}
				else
				{
					result[K--] = s.Peek();
				}
				s.Push(arr[i]);
			}
			return result;
		}
	}
}
