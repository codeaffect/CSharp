using System;
using System.Linq;

namespace MiniMaxSum
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            var sortedArr = arr.OrderBy(c=>c).ToArray();
            long miniSum = 0;
            long maxSum = 0;
            for(int i = 0; i < sortedArr.Length ; i++)
            {
                if(i>0)
                {
                    maxSum += sortedArr[i];
                }
                if (i<arr.Length-1)
                {
                    miniSum += sortedArr[i];
                }
            }
            Console.WriteLine($"{miniSum} {maxSum}");
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            miniMaxSum(arr);
        }
    }
}
