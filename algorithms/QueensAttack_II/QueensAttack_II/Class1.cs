using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueensAttack_II
{
    class Class1
    {

        static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {

            int u = n - r_q;
            int d = r_q - 1;
            int r = n - c_q;
            int l = c_q - 1;
            int ru = Math.Min(u, r);
            int lu = Math.Min(l, u);
            int rd = Math.Min(r, d);
            int ld = Math.Min(l, d);

            for (int i = 0; i < k; i++)
            {
                if (obstacles[i][1] == c_q)
                {
                    if (obstacles[i][0] < r_q)
                    {
                        d = Math.Min(d, r_q - obstacles[i][0] - 1);
                    }
                    else
                    {
                        u = Math.Min(u, obstacles[i][0] - r_q - 1);
                    }
                }
                else if (obstacles[i][0] == r_q)
                {
                    if (obstacles[i][1] < c_q)
                    {
                        l = Math.Min(l, c_q - obstacles[i][1] - 1);
                    }
                    else
                    {
                        r = Math.Min(r, obstacles[i][1] - c_q - 1);
                    }
                }
                else if (Math.Abs(obstacles[i][0] - r_q) == Math.Abs(obstacles[i][1] - c_q))
                {
                    if (obstacles[i][1] > c_q)
                    {
                        if (obstacles[i][0] > r_q)
                        {
                            ru = Math.Min(ru, obstacles[i][1] - c_q - 1);
                        }
                        else
                        {
                            rd = Math.Min(rd, c_q - obstacles[i][1] - 1);
                        }
                    }
                    else
                    {
                        if (obstacles[i][0] > r_q)
                        {
                            if (obstacles[i][1] > c_q)
                            {
                                lu = Math.Min(lu, c_q - obstacles[i][1] - 1);
                            }
                            else
                            {
                                ld = Math.Min(ld, c_q - obstacles[i][1] - 1);
                            }
                        }
                    }
                }
            }

            return u + d + r + l + ru + rd + lu + ld;
        }

        static void t(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            string[] r_qC_q = Console.ReadLine().Split(' ');

            int r_q = Convert.ToInt32(r_qC_q[0]);

            int c_q = Convert.ToInt32(r_qC_q[1]);

            int[][] obstacles = new int[k][];

            for (int i = 0; i < k; i++)
            {
                obstacles[i] = Array.ConvertAll(Console.ReadLine().Split(' '), obstaclesTemp => Convert.ToInt32(obstaclesTemp));
            }

            int result = queensAttack(n, k, r_q, c_q, obstacles);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
