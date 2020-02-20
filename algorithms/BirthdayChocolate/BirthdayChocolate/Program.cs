using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;// Convert.ToInt32(Console.ReadLine().Trim());

            var data = "1 2 1 3 2";// Console.ReadLine().TrimEnd();
            List<int> s = data.Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            data = "3 2";// Console.ReadLine().TrimEnd();
            string[] dm = data.Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = Birthday(s, d, m);
        }

        static int Birthday(List<int> s, int d, int m)
        {
            int result = 0;
            int runningCount = 0;
            int runningSum = 0;
            for (int i = 0; i < s.Count; i++)
            {
                runningSum += s[i];
                runningCount++;
                if (runningCount == m)
                {
                    if (runningSum == d)
                    {
                        result++;
                    }

                    i = i - runningCount + 1;
                    runningCount = runningSum = 0;
                }
            }

            return result;
        }
    }
}
