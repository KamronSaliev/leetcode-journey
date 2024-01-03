using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-laser-beams-in-a-bank/
    /// </summary>
    public class Medium2125_NumberOfLaserBeamsInABank
    {
        public int NumberOfBeams(string[] bank)
        {
            var result = 0;
            var current = Count(bank[0]);

            for (var i = 1; i < bank.Length; i++)
            {
                var next = Count(bank[i]);

                if (next == 0)
                {
                    continue;
                }

                result += current * next;
                current = next;
            }

            return result;
        }

        private int Count(string row)
        {
            return row.Sum(ch => ch - '0');
        }
    }
}