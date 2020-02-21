using System;
using System.Timers;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number of values");
            //int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            Console.WriteLine("Enter Search value:");
            int n = Convert.ToInt32(Console.ReadLine());

            Timer t = new Timer();

            t.Start();
            int result = Search(arr, n);
            if (result == -1)
            {
                Console.WriteLine("Can't Find!");
            }
            else
            {
                Console.WriteLine($"Found '{n}' at '{result+1}' position");
            }
            t.Stop();

            Console.WriteLine($"Time of execution:{t.Interval} ms");
        }

        private static int Search(int[] arr, int searchValue)
        {
            return BinarySearch(arr, 0, arr.Length - 1, searchValue);
        }

        private static int BinarySearch(int[] arr, int lo, int hi, int value)
        {
            if (lo >= hi) return -1;

            int midIndex = (hi+lo) / 2;
            int mid = arr[midIndex];

            if (mid == value) return (midIndex);

            if (value < mid)
            {
                return BinarySearch(arr, lo, midIndex, value);
            }
            else
            {
                return BinarySearch(arr, midIndex, hi, value);
            }
        }
    }
}
