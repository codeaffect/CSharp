using System;
using System.Collections.Generic;

namespace queensattack_2
{
    class Program
    {
        // start from left, clockwise, left and up, up, right and up, right, 
        //            right and down, down, left and down
        static int[] directions_row = new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };
        static int[] directions_col = new int[] { -1, -1, 0, 1, 1, 1, 0, -1 };

        static void Main(string[] args)
        {
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

            int result = QueensAttack(n, k, r_q, c_q, obstacles);
        }

        static int QueensAttack(int n, int k, int r_q, int c_q, int[][] obstacleList)
        {
            int rows = n;
            var queen = new Tuple<int, int>(r_q, c_q);
            var obstacles = new Tuple<int, int>[k];
            for (int i = 0; i < k; i++)
            {
                obstacles[i] = new Tuple<int, int>(obstacleList[i][0], obstacleList[i][1]);
            }

            // put all obstacles in a hashset
            var obstacleHashed = new HashSet<Tuple<int, int>>();
            foreach (Tuple<int, int> obstacle in obstacles)
            {
                obstacleHashed.Add(obstacle);
            }

            // go over each direction
            int count = 0;

            for (int i = 0; i < 8; i++)
            {
                int rowIncrement = directions_row[i];
                int colIncrement = directions_col[i];

                int runnerRow = queen.Item1 + rowIncrement;
                int runnerCol = queen.Item2 + colIncrement;

                while (runnerRow >= 0 && runnerRow < rows &&
                       runnerCol >= 0 && runnerCol < rows &&
                       !obstacleHashed.Contains(new Tuple<int, int>(runnerRow, runnerCol)))
                {
                    runnerRow += rowIncrement;
                    runnerCol += colIncrement;

                    count++;
                }
            }

            return count;
        }
    }
}
