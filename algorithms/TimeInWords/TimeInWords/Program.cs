using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 12;
            int m = 47;
            string result = TimeInWords(h, m);
        }

        static string TimeInWords(int h, int m)
        {
            string[] nums = { "zero", "one", "two", "three", "four",
                        "five", "six", "seven", "eight", "nine",
                        "ten", "eleven", "twelve", "thirteen",
                        "fourteen", "fifteen", "sixteen", "seventeen",
                        "eighteen", "nineteen", "twenty", "twenty one",
                        "twenty two", "twenty three", "twenty four",
                        "twenty five", "twenty six", "twenty seven",
                        "twenty eight", "twenty nine"  };

            string result = string.Empty;

            if (m == 0)
            {
                result = $"{nums[h]} o' clock";
            }
            else if (m >= 1 && m <= 30)
            {
                if (m == 15)
                {
                    result = $"quarter past {nums[h]}";
                }
                else
                {
                    result = $"{nums[m]} minutes past {nums[h]}";
                }
            }
            else if (m == 45)
            {
                result = $"quarter past {nums[h + 1]}";
            }
            else
            {
                result = $"{nums[60 - m]} minutes to {nums[h + 1]}";
            }
            return result;
        }

    }
}
