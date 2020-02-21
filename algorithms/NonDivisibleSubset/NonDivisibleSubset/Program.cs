using System;
using System.Collections.Generic;
using System.Linq;

namespace NonDivisibleSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = "6 3";// Console.ReadLine().TrimEnd();
            string[] firstMultipleInput = data.Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            data = "1 3 2 6 1 2";// Console.ReadLine().TrimEnd();
            List<int> s = data.Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            int result = DivisibleSumPairs(k, s.ToArray());

        }

        public static int DivisibleSumPairs(int k, int[] ar)
        {
            List<Tuple<int, int>> values = new List<Tuple<int, int>>();
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    if (i == j) { continue; }
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        if (CanInclude(i, j, values))
                        {
                            continue;
                        }

                        if (i <= j)
                        {
                            values.Add(Tuple.Create(i, j));
                        }
                        else
                        {
                            values.Add(Tuple.Create(j, i));
                        }
                    }
                }
            }

            return values.Count;
        }

        static bool CanInclude(int a, int b, List<Tuple<int, int>> values)
        {
            Tuple<int, int> value;

            if (a <= b)
            {
                value = Tuple.Create(a, b);
            }
            else
            {
                value = Tuple.Create(b, a);
            }

            return values.Contains(value);
        }
    }
}
