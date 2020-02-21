using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;// Convert.ToInt32(Console.ReadLine());

            var data = "10 5 20 20 4 5 2 25 1";// Console.ReadLine();

            int[] scores = Array.ConvertAll(data.Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));

            int[] result = BreakingRecords(scores);
        }

        static int[] BreakingRecords(int[] scores)
        {
            int[] results = new int[2] { 0, 0 };

            int min, max;

            min = max = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (min > scores[i])
                {
                    min = scores[i];
                    results[1] = ++results[1];
                }
                else if (max < scores[i])
                {
                    max = scores[i];
                    results[0] = ++results[0];
                }
            }

            return results;

        }

    }
}
