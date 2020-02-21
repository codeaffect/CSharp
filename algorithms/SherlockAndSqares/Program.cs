using System;

namespace SherlockAndSqares
{
    class Program
    {
        static int squares(int a, int b)
        {
            double squareRootOfA = Math.Sqrt(a);
            int squareRootOfAInteger = (int)Math.Ceiling(squareRootOfA);
            int startingNumber = (squareRootOfAInteger ^ 2) >= a ? squareRootOfAInteger - 1 : squareRootOfAInteger;
            
            if (startingNumber == 0) startingNumber++;

            double square = Math.Pow(startingNumber, 2);
            int count = 0;

            while (square <= b)
            {
                startingNumber++;
                square = Math.Pow(startingNumber, 2);
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            int a, b,count;
            string code="a";

            while (1==1)
            {
                Console.WriteLine(">>>>> Enter Values:");
                code = Console.ReadLine();
                if (code.ToLower() == "x") break;
                a = Convert.ToInt32(code.Split(' ')[0]);
                b = Convert.ToInt32(code.Split(' ')[1]);

                count = squares(a, b);
                Console.WriteLine($"Number Of perfect squares in between:{count}");
                Console.WriteLine();
            }
        }
    }
}
