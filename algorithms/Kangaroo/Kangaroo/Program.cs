using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1V1X2V2 = "43 2 70 2".Split(' ');// Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            var result = Kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }

        static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            int a = x2 - x1;
            int b = v1 - v2;
            if (a < 0 || b < 0) return "NO";
            if (b == 0) return a == 0 ? "YES" : "NO";
            return a % b == 0 ? "YES" : "NO";
        }
    }
}
