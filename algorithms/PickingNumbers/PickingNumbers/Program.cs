using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start >> Enter Numbers:");
            var x = Console.ReadLine();
            while (x != "x")
            {
                if (!string.IsNullOrWhiteSpace(x))
                {

                    List<int> integers = x.Split().Select(c => Convert.ToInt32(c)).ToList();
                    var result = PickingNumbers(integers);

                    Console.WriteLine($"Result >> {result}");
                }
                Console.WriteLine();
                Console.WriteLine("Enter Any Key to Continue. If not 'x' to exit.");
                x = Console.ReadLine();
            }
        }

        static int PickingNumbers(List<int> a)
        {
            var groupedInts = a.GroupBy(c => c)
                               .ToDictionary(d => d.Key, d => d.Count());

            var orderedDictionaryValues = groupedInts.OrderByDescending(c => c.Value).ToList();
            List<int> resultInts = new List<int>();
            int result = 0;

            if (orderedDictionaryValues.First().Value == 1)
            {
                var ordered = a.OrderBy(c => c).ToList();
                for (int i = 1; i < ordered.Count; i++)
                {
                    if (ordered[i] - ordered[i - 1] == 1) { return 2; }
                }
                return 0;
            }
            int maxCount = 0;

            for (int i = 0; i < orderedDictionaryValues.Count(); i++)
            {
                var value = orderedDictionaryValues[i].Key;

                var nearCountsUpper = a.Where(x => x - value == 1).ToArray();

                var nearCountsLower = a.Where(x => value - x == 1).ToArray();

                if (nearCountsLower.Length == 0 && nearCountsUpper.Length == 0)
                {
                    maxCount = maxCount<orderedDictionaryValues[i].Value? orderedDictionaryValues[i].Value:maxCount;
                }
                else
                {
                    var nearInts = nearCountsUpper.Length >= nearCountsLower.Length ? nearCountsUpper : nearCountsLower;

                    result = nearInts.First();
                    resultInts = a.Where(x => x == result || x == value).Select(c => c).ToList();
                    maxCount = resultInts.Count > maxCount ? resultInts.Count : maxCount;
                }
            }
            return maxCount;
        }
    }
}
