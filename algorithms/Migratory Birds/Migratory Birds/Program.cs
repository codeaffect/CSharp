using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migratory_Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = 11;// Convert.ToInt32(Console.ReadLine().Trim());
            var data = "1 2 3 4 5 4 3 2 1 3 4";// Console.ReadLine().TrimEnd();
            List<int> arr = data.Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MigratoryBirds(arr);
        }

        static int MigratoryBirds(List<int> arr)
        {
            var list = arr
                        .GroupBy(c => c)
                        .Select(d => new
                        {
                            id = d.Key,
                            count = d.Count()
                        })
                        .OrderBy(x => x.count)
                        .ToList();

            list.ForEach(i => Console.WriteLine($"{i.id} -- {i.count}"));

            var maxValue = list.Any(c => c.count>1);
            if (maxValue)
            {
                return list.Where(c => c.count>1).OrderByDescending(o => o.count).ThenBy(t => t.id).First().id;
            }
            return list.OrderBy(c=>c.id).First().id;
        }
    }
}
