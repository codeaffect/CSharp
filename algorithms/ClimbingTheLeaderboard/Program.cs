using System;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingTheLeaderboard
{
    class Program
    {
        /*
         * Scores are in descending order
         * Alice Scores are in ascending order
         */
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //int scoresCount = Convert.ToInt32(Console.ReadLine());
            string scorestr = "295 294 291 287 287 285 285 284 283 279 277 274 274 271 270 268 268 268 264 260 259 258 257 255 252 250 244 241 240 237 236 236 231 227 227 227 226 225 224 223 216 212 200 197 196 194 193 189 188 187 183 182 178 177 173 171 169 165 143 140 137 135 133 130 130 130 128 127 122 120 116 114 113 109 106 103 99 92 85 81 69 68 63 63 63 61 57 51 47 46 38 30 28 25 22 15 14 12 6 4";
            string alicestr = "5 5 6 14 19 20 23 25 29 29 30 30 32 37 38 38 38 41 41 44 45 45 47 59 59 62 63 65 67 69 70 72 72 76 79 82 83 90 91 92 93 98 98 100 100 102 103 105 106 107 109 112 115 118 118 121 122 122 123 125 125 125 127 128 131 131 133 134 139 140 141 143 144 144 144 144 147 150 152 155 156 160 164 164 165 165 166 168 169 170 171 172 173 174 174 180 184 187 187 188 194 197 197 197 198 201 202 202 207 208 211 212 212 214 217 219 219 220 220 223 225 227 228 229 229 233 235 235 236 242 242 245 246 252 253 253 257 257 260 261 266 266 268 269 271 271 275 276 281 282 283 284 285 287 289 289 295 296 298 300 300 301 304 306 308 309 310 316 318 318 324 326 329 329 329 330 330 332 337 337 341 341 349 351 351 354 356 357 366 369 377 379 380 382 391 391 394 396 396 400";

            //string scorestr = "12 6 4";
            //string alicestr = "5 5 6 14 19";
            int[] scores = Array.ConvertAll(scorestr.Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            //int aliceCount = Convert.ToInt32(Console.ReadLine());

            int[] alice = Array.ConvertAll(alicestr.Split(' '), aliceTemp => Convert.ToInt32(aliceTemp));

            int[] result = climbingLeaderboard(scores, alice);

            Console.WriteLine("Results:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }

        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int scoresLen = scores.Length;
            int aliceLen = alice.Length;

            int[] res = new int[aliceLen];
            int[] rank = new int[scoresLen];

            rank[0] = 1;

            for (int i = 1; i < scoresLen; i++)
            {
                if (scores[i] == scores[i - 1])
                {
                    rank[i] = rank[i - 1];
                }
                else
                {
                    rank[i] = rank[i - 1] + 1;
                }
            }

            for (int i = 0; i < aliceLen; i++)
            {
                int aliceScore = alice[i];
                if (aliceScore > scores[0])
                {
                    res[i] = 1;
                }
                else if (aliceScore < scores[scoresLen - 1])
                {
                    res[i] = rank[scoresLen - 1] + 1;
                }
                else
                {
                    int index = binarySearch(scores, aliceScore);
                    res[i] = rank[index];

                }
            }
            return res;
        }
        private static int binarySearch(int[] a, int key)
        {

            int lo = 0;
            int hi = a.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (a[mid] == key)
                {
                    return mid;
                }
                else if (a[mid] < key && key < a[mid - 1])
                {
                    return mid;
                }
                else if (a[mid] > key && key >= a[mid + 1])
                {
                    return mid + 1;
                }
                else if (a[mid] < key)
                {
                    hi = mid - 1;
                }
                else if (a[mid] > key)
                {
                    lo = mid + 1;
                }
            }
            return -1;
        }
    }
}

/*
 int avi = aliceCount - 1;

            int aliceValue = alice[avi];

            int rank = 1;

            for (int j = 0; j < scores.Length; j++)
            {
                if (j > 0 && scores[j] == scores[j - 1])
                {
                    continue;
                }
                if (aliceValue >= scores[j])
                {
                    results[avi] = rank;
                    avi--;
                    for (int i = avi; i >= 0; i--)
                    {
                        if (i != aliceCount - 1 && alice[i] == alice[i + 1])
                        {
                            results[i] = rank;
                            continue;
                        }
                        break;
                    }
                    if (avi < 0) { break; }
                    aliceValue = alice[avi];
                }
                rank++;
            }

            for (int i = avi; i >= 0; i--)
            {
                if (i != aliceCount - 1 && alice[i] == alice[i + 1])
                {
                    results[i] = rank;
                    continue;
                }
                results[i] = rank++;
            }
 */

/*
var sortedScores = scores.ToList();

sortedScores.AddRange(alice);

var sortedArray = sortedScores.OrderByDescending(c => c).Distinct().ToArray();

for (int j = 0; j < alice.Length; j++)
{
    var indexValue = Array.IndexOf(sortedArray, alice[j]);

    results.Add(indexValue+1);
}
*/
/*

 for (int j = 0; j < alice.Length; j++)
{
    var sortedScores = scores.ToList();

    sortedScores.Add(alice[j]);

    var sortedArray = sortedScores.OrderByDescending(c => c).Distinct().ToArray();

    var indexValue = Array.IndexOf(sortedArray, alice[j]);

    results.Add(indexValue+1);
}
// */
