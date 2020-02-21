using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = "5";// Console.ReadLine();
            var data = "0";//Console.ReadLine();

            int n = Convert.ToInt32(count);
            int p = Convert.ToInt32(data);

            int result = PageCount(n, p);
        }

        static int PageCount(int n, int p)
        {
            if (n <= 1 || p <= 1) return 0;
            n = n % 2 == 0 ? n + 1 : n;
            if (n - p <= 1)
            {
                return n % 2 == 0 ? 1 : 0;
            }
            int result = 0;
            result = (n / 2 >= p) ? p / 2 : (n - p) / 2;
            return result;
        }
    }
}
