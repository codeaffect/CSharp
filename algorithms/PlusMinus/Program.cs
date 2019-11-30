using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
        static void plusMinus(int[] arr)
        {
            double countOfBelowZero = arr.Count(c => c < 0);
            double countOfAboveZero = arr.Count(c => c > 0);
            double countOfZero = arr.Count(c => c == 0);
            Console.WriteLine(Math.Round(countOfAboveZero / arr.Length, 6));
            Console.WriteLine(Math.Round(countOfBelowZero / arr.Length, 6));
            Console.WriteLine(Math.Round(countOfZero / arr.Length, 6));
        }
    }
}
