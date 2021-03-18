using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class RainWaterTrapping
	{
		public static int TotalAreaOfWater(int[] arr)
		{
			int totalWater = 0;
			int n = arr.Length;
			int maxLeft = int.MinValue;
			int maxRight = int.MinValue;
			int[] maxToLeft = new int[n];
			int[] maxToRight = new int[n];

			for(int i = 0; i<n; i++)
			{
				maxLeft = Math.Max(maxLeft, arr[i]);
				maxToLeft[i] = maxLeft;
			}
			for(int i = n-1; i >= 0; i--)
			{
				maxRight = Math.Max(maxRight, arr[i]);
				maxToRight[i] = maxRight;
			}
			for(int i = 0; i<n;i++)
			{
				totalWater += Math.Min(maxToLeft[i], maxToRight[i]) - arr[i];
			}
			return totalWater;
		}
	}
}
