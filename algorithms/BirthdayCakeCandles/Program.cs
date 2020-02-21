using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            var result = 1;
            var sArr = ar.OrderByDescending(c => c).ToArray();
            for(int i = 1; i < sArr.Length; i++)
            {
                if (sArr[i] < sArr[i - 1]) { break; }
                result++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = birthdayCakeCandles(ar);
            Console.WriteLine(result);
        }
    }
}
