using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVerma.Stack
{
	class MaximumAreaOfHistogram
	{
		public static int MaximumAreaOfTheHistogram(List<int> arr)
		{
			int max = int.MinValue;
			Stack<(int,int)> leftStack = new Stack<(int, int)>();
			Stack<(int, int)> rightStack = new Stack<(int, int)>();
			List<int> smallerToLeft = new List<int>();
			List<int> smallerToRight = new List<int>();
			List<int> width = new List<int>();
			List<int> area = new List<int>();

			for (int i = 0; i< arr.Count; i++)
			{
				if(leftStack.Count == 0)
				{
					smallerToLeft.Add(-1);
				}
				else if(leftStack.Count > 0 && leftStack.Peek().Item1 < arr[i])
				{
					smallerToLeft.Add(leftStack.Peek().Item2);
				}
				else if(leftStack.Count > 0 && leftStack.Peek().Item1 >= arr[i])
				{
					 while(leftStack.Count > 0 && leftStack.Peek().Item1 >= arr[i])
					{
						leftStack.Pop();
					}
					if(leftStack.Count == 0)
					{
						smallerToLeft.Add(-1);
					}
					else
					{
						smallerToLeft.Add(leftStack.Peek().Item2);
					}
				}
				leftStack.Push((arr[i], i));
			}

			for(int i = arr.Count - 1; i>=0; i--)
			{
				if(rightStack.Count == 0)
				{
					smallerToRight.Add(arr.Count);
				}
				else if(rightStack.Count > 0 && rightStack.Peek().Item1 < arr[i])
				{
					smallerToRight.Add(rightStack.Peek().Item2);
				}
				else if(rightStack.Count > 0 && rightStack.Peek().Item1 >= arr[i])
				{
					while(rightStack.Count > 0 && rightStack.Peek().Item1 >= arr[i])
					{
						rightStack.Pop();
					}
					if(rightStack.Count == 0)
					{
						smallerToRight.Add(arr.Count);
					}
					else
					{
						smallerToRight.Add(rightStack.Peek().Item2);
					}
				}
				rightStack.Push((arr[i], i));
			}

			smallerToRight.Reverse();

			for(int i = 0; i < arr.Count; i++)
			{
				width.Add(smallerToRight[i] - smallerToLeft[i] - 1);
				area.Add(width[i] * arr[i]);
			}
			max = area[0];
			for(int i = 1; i<arr.Count; i++)
			{
				if (max < area[i])
					max = area[i];
			}
			return max;
		}
	}
}
