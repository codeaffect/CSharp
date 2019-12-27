using System;
using System.Timers;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== Merge Sort ====");
            Console.WriteLine("Enter Integers seperated by <single space>:");
            //string inputArgs = Console.ReadLine();
            string inputArgs = InputParams.Args;
            int[] input = Array.ConvertAll(inputArgs.Split(" "), x => Convert.ToInt32(x));
            Sort(input);
        }

        static void Sort(int[] arr)
        {
            Timer t = new Timer();
            t.Start();
            int[] results = MergeSort(arr, new int[arr.Length], 0, arr.Length - 1);
            t.Stop();
            Console.WriteLine("****  Results are:-");
            Console.WriteLine(string.Join(", ", results));
            Console.WriteLine($" ****** Execution Time:{t.Interval} ms");
        }

        static int[] MergeSort(int[] arr, int[] tmp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return arr;
            }

            int middle = (rightEnd + leftStart) / 2;
            MergeSort(arr, tmp, leftStart, middle);
            MergeSort(arr, tmp, middle + 1, rightEnd);
            return Merge(arr, tmp, leftStart, rightEnd);
        }

        static int[] Merge(int[] arr, int[] tmp, int leftStart, int rightEnd)
        {
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int index = leftStart;
            int left = leftStart;
            int right = rightStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (arr[left] < arr[right])
                {
                    tmp[index] = arr[left];
                    left++;
                }
                else
                {
                    tmp[index] = arr[right];
                    right++;
                }
                index++;
            }

            Array.Copy(arr, left, tmp, index, leftEnd - left + 1);
            Array.Copy(arr, right, tmp, index, rightEnd - right + 1);
            Array.Copy(tmp, leftStart, arr, leftStart, size);

            return arr;
        }
    }
}
