using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                grades[i] = grades[i] < 38 ? grades[i] : RoundedValue(grades[i]);
            }

            return grades;
        }

        private static int RoundedValue(int grade)
        {
            if (grade % 5 == 0) return grade;
            int valueByFive = grade / 5;

            int nextValue = 5 * (valueByFive + 1);

            return (nextValue - grade) < 3 ? nextValue : grade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            Console.WriteLine("----------");

            Console.WriteLine(string.Join('\n', result.ToArray()));
        }
    }
}
