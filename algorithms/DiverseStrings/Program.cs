using System;

namespace DiverseStrings
{
    class Program
    {
        public static string solve(int n, int k)
        {
            if(n==1) { return "a"; }
            if (n % k == 0) { return "NONE"; }

            int firstChar = 1;

            int numOfCharInBetween = n % k;

            string prefix = "";
            for (int i = 0; i < n / 2 - 1; i++)
            {
                string repeatableChar = Number2String(firstChar++);
                
                for (int j = 0; j < k; j++)
                {
                    prefix += repeatableChar;
                    i++;
                }
            }

            string middleCharValue = "";
            for (int j = 0; j < numOfCharInBetween; j++)
            {
                middleCharValue += Number2String(firstChar++);
            }

            string result = prefix + middleCharValue + prefix;

            return result;
        }
        static void Main(string[] args)
        {
            string input;
            string result;
            int n, k;
            while (1 == 1)
            {
                Console.WriteLine(">> Enter Values:");
                input = Console.ReadLine();
                if (input.ToLower() == "x") { break; }
                string[] s = input.Split(' ');

                n = Convert.ToInt32(s[0]);
                k = Convert.ToInt32(s[1]);

                result = solve(n, k);
                Console.WriteLine($"Result:-{result}");
            }
        }

        private static string Number2String(int number, bool isCaps = false)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number - 1));
            return c.ToString();
        }
    }
}
