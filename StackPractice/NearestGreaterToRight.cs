using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class NearestGreaterToRight
	{
		public static int[] NearestElementGreaterToRight(List<int> arr)
		{
			int n = arr.Count;
			int k = n - 1;
			int[] result = new int[n];

			Stack<int> s = new Stack<int>();

			for (int i = n - 1; i >= 0; i--)
			{
				while (s.Count > 0 && s.Peek() <= arr[i])
				{
					s.Pop();
				}

				if (s.Count == 0)
				{
					result[k--] = -1;
				}
				else
				{
					result[k--] = s.Peek();
				}
				s.Push(arr[i]);
			}
			return result;
		}
	}
}
