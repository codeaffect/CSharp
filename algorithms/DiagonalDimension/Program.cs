using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiagonalDimension
{
    class Program
    {
        static void Main(string[] args)
        {
         //   TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumOfA = 0;
            int sumOfB = 0;
            int maxWidth = arr[0].Count-1;
            for(int i = 0; i < arr.Count ; i++)
            {
                sumOfA += arr[i][i];
                sumOfB += arr[i][maxWidth - i];
            }
            Console.WriteLine($"SumA:-{sumOfA}");
            Console.WriteLine($"SumB:-{sumOfB}");
            return Math.Abs(sumOfA-sumOfB);
        }



    }

}
