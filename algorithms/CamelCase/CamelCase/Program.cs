using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)'A');
            Console.WriteLine((int)'Z');
            Console.WriteLine((int)'a');
            Console.WriteLine((int)'z');

            string s = "saveChangesInTheEditor";// Console.ReadLine();

            int result = CamelCase(s);

        }

        static int CamelCase(string s)
        {
            const int ua = (int)'A';
            const int uz = (int)'Z';

            int count = 1;
            var arr = s.ToCharArray();

            if (arr.Length == 0) return 0;

            for(int i = 1; i < arr.Length; i++)
            {
                var x= (int)arr[i];
                if(x>=ua && x <= uz)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
