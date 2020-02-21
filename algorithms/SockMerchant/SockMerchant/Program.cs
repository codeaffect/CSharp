using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = "9";// Console.ReadLine();
            var data = "10 20 20 10 10 30 50 10 20";// Console.ReadLine();

            int n = Convert.ToInt32(count);

            int[] ar = Array.ConvertAll(data.Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = SockMerchant(n, ar);
        }
        static int SockMerchant(int n, int[] ar)
        {
            int result = 0;

            var data = ar.GroupBy(g => g)                    
                        .Select(c => new { id = c, count = c.Count() })
                        ;

            result = data.Where(c => c.count != 1)
                    .Sum(s => s.count /2);

            return result;
        }
    }
}
