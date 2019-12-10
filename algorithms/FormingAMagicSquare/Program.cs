using System;
using System.Collections.Generic;

namespace FormingAMagicSquare
{
    class Program
    {
        private static readonly int[,,] possibleMagicSquares = new int[,,]
        {
            {{8, 1, 6},{3, 5, 7},{4, 9, 2}},
            {{4, 3, 8},{9, 5, 1},{2, 7, 6}},
            {{2, 9, 4},{7, 5, 3},{6, 1, 8}},
            {{6, 7, 2},{1, 5, 9},{8, 3, 4}},
            {{6, 1, 8},{7, 5, 3},{2, 9, 4}},
            {{8, 3, 4},{1, 5, 9},{6, 7, 2}},
            {{4, 9, 2},{3, 5, 7},{8, 1, 6}},
            {{2, 7, 6},{9, 5, 1},{4, 3, 8}}
        };

        static int formingMagicSquare(int[][] inputArr)
        {
            int minDiff = Int32.MaxValue;

            for (int o = 0; o < possibleMagicSquares.GetLength(0); ++o)
            {
                int diffSum = 0;
                for (int x = 0; x < 3; ++x)
                {
                    for (int y = 0; y < 3; ++y)
                    {
                        diffSum += Math.Abs(possibleMagicSquares[o, y, x] - inputArr[y][x]);
                    }
                }

                minDiff = Math.Min(minDiff, changeCount);
            }

            return minDiff;
        }

        static void Main(string[] args)
        {
            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);

            Console.WriteLine($"Result:-{result}");
        }
    }
}
