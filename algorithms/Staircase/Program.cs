using System;

namespace Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
