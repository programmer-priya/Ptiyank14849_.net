using System;

namespace BlockApp
{

    

    class Program
    {
       public static void Func1(int[] arr, out int a, out int b)
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

            a = arr[0];
            b = arr[arr.Length - 1];

        }

        static void Main(string[] args)
        {
            int[] myArray = { 23, 92, 56, 39, 93 };
            int a = 0;
            int b = 0;
            Func1(myArray, out a,out b);

            Console.WriteLine("Maximum value in the array is::" + a );
            Console.WriteLine("Minimum value in the array is::" + b );
        }
      
      }
    }
