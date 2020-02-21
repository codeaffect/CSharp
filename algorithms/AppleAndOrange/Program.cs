using System;

namespace AppleAndOrange
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int nApples = 0, nOranges = 0;
            int sum = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                sum = a + apples[i];
                if (sum >= s && sum <= t) nApples++;
            }
            Console.WriteLine(nApples);
            for (int i = 0; i < oranges.Length; i++)
            {
                sum = b + oranges[i];
                if (sum >= s && sum <= t) nOranges++;
            }
            Console.WriteLine(nOranges);
        }
        static void Main(string[] args)
        {
            string ststr, abstr, mnstr, applestr, orangestr;

            //ststr = Console.ReadLine();
            //abstr = Console.ReadLine();
            //mnstr = Console.ReadLine();
            //applestr = Console.ReadLine();
            //orangestr = Console.ReadLine();

            ststr = "7 11";
            abstr = "5 15";
            mnstr = "3 2";
            applestr = "-2 1 2";
            orangestr = "5 -6";

            string[] st = ststr.Split(' ');
            string[] ab = abstr.Split(' ');
            string[] mn = mnstr.Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);


            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);


            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(applestr.Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(orangestr.Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
