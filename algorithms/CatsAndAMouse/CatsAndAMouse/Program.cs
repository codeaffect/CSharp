using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndAMouse
{
    class Program
    {
        static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = CatAndMouse(x, y, z);

                Console.WriteLine(result);
            }
        }
        static string CatAndMouse(int x, int y, int z)
        {
            int a = Math.Abs(z - x);
            int b = Math.Abs(z - y);
            if (a == b)
            {
                return "Mouse C";
            }

            return a < b ? "Cat A" : "Cat B";
        }
    }
}
