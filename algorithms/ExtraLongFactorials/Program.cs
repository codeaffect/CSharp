using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var factorial = BigInteger.One;
            for (int i = 1; i <= n; i++)
                factorial = factorial * i;

            Console.WriteLine(factorial);
        }
    }
}
