using System;
using System.Linq;

namespace PivotStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "";
            while (x != "x")
            {
                Console.WriteLine("Enter a sentence:");
                var data = Console.ReadLine();
                Encryption(data);
            }
        }

        static string Encryption(string s)
        {
            var datanospace = s.Replace(" ", "");
            int len = datanospace.Length;
            var ns = Math.Sqrt((double)len);
            int rows = (int)Math.Floor(ns);
            int columns = (int)Math.Ceiling(ns);
            if (rows * columns < len)
            {
                rows = columns;
            }
            string[] strArray = new string[rows];
            int counter = 0;
            for (int i = 0; i < rows; i++)
            {
                if (columns > len - i - counter)
                {
                    strArray[i] = datanospace.Substring(i + counter, len - i - counter).PadRight(columns);
                }
                else
                {
                    strArray[i] = datanospace.Substring(i + counter, columns).PadRight(columns);
                }
                counter += (columns - 1);
            }
            return PivotStrings(strArray, rows, columns);
        }

        static string PivotStrings(string[] strings, int rows, int columns)
        {
            char[][] strArray = strings.Select(c => c.ToCharArray()).ToArray();
            var result = string.Empty;
            for (int i = 0; i < columns; i++)
            {
                var tmp = string.Empty;
                for (int j = 0; j < rows; j++)
                {
                    tmp += strArray[j][i];
                }
                result = i == 0 ? tmp : $"{result} {tmp.Trim()}";
            }

            //Console.WriteLine(result);
            return result;
        }
    }
}
