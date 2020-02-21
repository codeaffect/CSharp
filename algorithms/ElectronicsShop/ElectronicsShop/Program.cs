using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var bnmdata = Console.ReadLine();
            var keyboardData = Console.ReadLine();
            var drivesData = Console.ReadLine();

            string[] bnm = bnmdata.Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(keyboardData.Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(drivesData.Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = GetMoneySpent(keyboards, drives, b);
        }

        static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxCount = 0;
            int sum = 0;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    sum = keyboards[i] + drives[j];
                    if (sum > maxCount && sum <= b) { maxCount = sum; }
                }
            }

            return maxCount == 0 ? -1 : maxCount;
        }
    }
}
