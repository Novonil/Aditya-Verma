using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.StackPractice
{
	class MaximumAreaOfRectangleInBinaryMatrix
	{
		public static int MaxArea(int[,] arr)
		{
			int max = int.MinValue;
			int[] sum = new int[arr.Length];
			for(int i = 0; i < arr.GetLength(0); i++)
			{
				for(int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i,j] == 0)
					{
						sum[j] = 0;
					}
					else
					{
						sum[j] += arr[i,j];
					}
				}
				max = Math.Max(max,MaximumAreaOfHistogram.MaxAreaOfHistogram(sum));	
			}
			return max;
		}
	}
}
