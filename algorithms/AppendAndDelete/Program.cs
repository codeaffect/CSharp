using System;

namespace AppendAndDelete
{
    class Program
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int commonLetters = 0;
            int counterLen = Math.Min(s.Length, t.Length);
            for (int i = 0; i < counterLen; i++)
            {
                if (s[i] != t[i])
                {
                    break;
                }
                commonLetters++;
            }

            int totalCount = s.Length + t.Length;

            if (totalCount - 2 * commonLetters > k) { return "No"; }

            // For every non-matching char in s, delete it and add a char from t (2 operations - delete, add).
            // Any remaining operations can be done at the beginning as delete operations for matching chars as well.
            if ((totalCount - 2 * commonLetters) % 2 == k % 2) { return "Yes"; }

            // We have enough operations left to delete the entire string s and append t.length caharacters
            return (totalCount < k) ? "Yes" : "No";
        }

        static void Main(string[] args)
        {
            /* 
               string s = Console.ReadLine();
               string t = Console.ReadLine();
               int k = Convert.ToInt32(Console.ReadLine());
               */
            string s = "hackerhappy";
            string t = "hackerrank";
            int k = 9;

            s = "y";
            t = "yu";
            k = 2;

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
        }
    }
}
