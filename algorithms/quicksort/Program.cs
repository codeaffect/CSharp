using System;
using System.Timers;

namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Timer t = new Timer();

            t.Start();
            int[] results = Sort(arr);
            t.Stop();
            Console.WriteLine(string.Join('\t', results));
            Console.WriteLine($"Time executed in ms:{t.Interval}");
        }

        private static int[] Sort(int[] arr)
        {
            return QuickSort(arr, 0, arr.Length - 1);
        }

        private static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return arr;

            int pivot = arr[(left + right) / 2];
            int pindex = Partition(arr, left, right, pivot);

            QuickSort(arr, left, pindex - 1);
            QuickSort(arr, pindex, right);

            return arr;
        }

        private static int Partition(int[] arr, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    //swap
                    int tmp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = tmp;

                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
