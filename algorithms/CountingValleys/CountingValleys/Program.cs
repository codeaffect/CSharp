using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = "8";// Console.ReadLine();
            string s = "UDDDUDUU";// Console.ReadLine();

            int n = Convert.ToInt32(count);

            int result = CountingValleys(n, s);
        }

        static int CountingValleys(int n, string s)
        {
            int result = 0;

            bool goingDown = false;
            int seaLevel = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }
                if (goingDown && seaLevel == 0)
                {
                    result++;
                    goingDown = false;
                }
                if (!goingDown && seaLevel < 0)
                {
                    goingDown = true;
                }
            }
            return result;
        }
    }
}
