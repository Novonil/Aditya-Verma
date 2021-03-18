using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.SlidingWindow
{
	class MaxSumSubArrayOfSizeK
	{
		public static long MaximumSumSubArrayOfSizeK(int[] arr, int K)
		{
			int i = 0, j = 0;
			long sum = 0, maxSum = int.MinValue;

			while(j != arr.Length)
			{
				sum += arr[j];
				if(j-i+1 < K)
				{
					j++;
				}
				else if(j-i+1 == K)
				{
					maxSum = Math.Max(maxSum, sum);
					sum -= arr[i];
					i++;
					j++;
				}
			}
			return maxSum;
		}
	}
}
