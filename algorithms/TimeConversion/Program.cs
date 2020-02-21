using System;

namespace TimeConversion
{
    class Program
    {
        /*
        * Complete the timeConversion function below.
        */
        static string timeConversion(string s)
        {
            var hours = s.Split(':')[0];
            if (s.ToLower().EndsWith("am"))
            {
                if (Convert.ToInt32(hours) < 12)
                {
                    return s.Substring(0,s.Length-2);
                }
                else
                {
                    hours = "00";
                }
            }
            else
            {
                if (Convert.ToInt32(hours) != 12)
                {
                    hours = (Convert.ToInt32(hours) + 12).ToString();
                }
            }

            var result = hours + s.Substring(2, s.Length-4);
            return result;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
