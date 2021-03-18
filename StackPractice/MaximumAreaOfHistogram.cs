using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class MaximumAreaOfHistogram
	{
		public static int MaxAreaOfHistogram(int[] arr)
		{
			int max = int.MinValue;
			int k = 0;
			int n = arr.Length;
			Stack<(int, int)> nsl = new Stack<(int, int)>();
			Stack<(int, int)> nsr = new Stack<(int, int)>();
			int[] leftResult = new int[n];
			int[] rightResult = new int[n];

			for(int i = 0; i<n; i++)
			{
				while(nsl.Count > 0 && nsl.Peek().Item1 >= arr[i])
				{
					nsl.Pop();
				}
				if(nsl.Count == 0)
				{
					leftResult[k++] = -1;
				}
				else
				{
					leftResult[k++] = nsl.Peek().Item2;
				}
				nsl.Push((arr[i], i));
			}

			k = n - 1;
			
			for(int i = n-1; i >= 0; i--)
			{
				while(nsr.Count > 0 && nsr.Peek().Item1 >= arr[i])
				{
					nsr.Pop();
				}
				if(nsr.Count == 0) 
				{
					rightResult[k--] = n;
				}
				else
				{
					rightResult[k--] = nsr.Peek().Item2;
				}
				nsr.Push((arr[i],i));
			}


			for(int i = 0; i<n;i++)
			{
				max = Math.Max(max,(rightResult[i] - leftResult[i] - 1) * arr[i]);
			}

			return max;
 		}
	}
}
