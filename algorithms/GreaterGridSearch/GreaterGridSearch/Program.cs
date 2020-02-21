using System;
using System.Collections.Generic;
using System.Linq;

namespace GreaterGridSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var gridData = new List<string>();
            var patternData = new List<string>();
            string[] data = System.IO.File.ReadAllLines(@"..\..\..\data.txt");

            string[] gridParams = data[counter].Split(' ');
            int rows = Convert.ToInt32(gridParams[counter++]);

            for (int i = counter; i <= rows; i++)
            {
                gridData.Add(data[i]);
                counter++;
            }

            string[] patternCount = data[counter++].Split(' ');
            rows = Convert.ToInt32(patternCount[0]) + counter;

            for (int i = counter; i < rows; i++)
            {
                patternData.Add(data[i]);
            }
            var result = gridSearch(gridData.ToArray(), patternData.ToArray());
            Console.WriteLine("Hello World!");
        }
        static string gridSearch(string[] G, string[] P)
        {
            if (G.Length < P.Length) return "NO";
            int index = 0;
            int counter = 0;
            int yesAnswer = 0;
            for (int p = 0; p < P.Length; p++)
            {
                for (; counter < G.Length; counter++)
                {
                    if (G[counter].Contains(P[p]))
                    {
                        var newindex = G[counter].IndexOf(P[p]);
                        if (newindex != index)
                        {
                            index = newindex;
                            if (yesAnswer != 0) return "NO";
                        }
                        yesAnswer++; counter++; break;
                    }
                }
            }
            return yesAnswer == P.Length ? "YES" : "NO";
        }
    }
}
