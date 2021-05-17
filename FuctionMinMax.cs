using System;

namespace FunctionApp
{
    class Program
    {
		static int[] Func1(int[] arr)
		{ 
			int temp = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (arr[i] > arr[j])
					{
						temp = arr[j];
						arr[j] = arr[i];
						arr[i] = temp;
					}
				}
			}

			int[] arr2 = new int[2];
			arr2[0] = arr[0];
			arr2[1] = arr[1];

			return arr2;
		}
		static void Main(string[] args)
        {
			 
			int[] myArray = { 23, 92, 56, 39, 93 };
			int[] result = Func1(myArray);
			Console.WriteLine("Maximum value in the array is::" + result[0]);
			Console.WriteLine("Minimum value in the array is::" + result[1]);
		}
    }
}
