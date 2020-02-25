using System;
using System.Linq;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Max Heigth Dan Can Jump:");
            var data = Console.ReadLine();
            var k = Convert.ToInt32(data);
            Console.WriteLine("Enter Hurdles:");
            data = Console.ReadLine();
            int[] height = data.ToCharArray().Select(c => Convert.ToInt32(c)).ToArray();
            var result = HurdleRace(k, height);

            Console.WriteLine($"Magic Potion Doses:{result}");
        }

        static int HurdleRace(int k, int[] height)
        {
            var diff = height.Max() - k;
            if (diff > 0) return diff;
            return 0;
        }
    }
}
