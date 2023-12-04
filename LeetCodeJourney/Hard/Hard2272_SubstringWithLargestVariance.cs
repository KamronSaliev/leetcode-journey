using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/substring-with-largest-variance/
    ///     https://leetcode.com/problems/substring-with-largest-variance/solutions/2854967/o-n-time-o-1-space/
    /// </summary>
    public class Hard2272_SubstringWithLargestVariance
    {
        public int LargestVariance(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            {
                return 0;
            }

            var distinct = new HashSet<char>();
            foreach (var c in s)
            {
                distinct.Add(c);
            }

            var maxVariance = 0;
            foreach (var max in distinct)
            {
                foreach (var min in distinct)
                {
                    if (max == min)
                    {
                        continue;
                    }

                    maxVariance = Math.Max(maxVariance, GetVariance(max, min, s));
                }
            }

            return maxVariance;
        }

        private int GetVariance(char max, char min, string s)
        {
            var maxVariance = 0;
            var variance = 0;
            var hasMin = false;
            var startsWithMin = false;

            foreach (var c in s)
            {
                if (c != max && c != min)
                {
                    continue;
                }

                if (c == max)
                {
                    variance++;
                }
                else if (c == min)
                {
                    hasMin = true;
                    if (startsWithMin && variance >= 0)
                    {
                        startsWithMin = false;
                    }
                    else if (variance - 1 < 0)
                    {
                        startsWithMin = true;
                        variance = -1;
                    }
                    else
                    {
                        variance--;
                    }
                }

                if (hasMin)
                {
                    maxVariance = Math.Max(maxVariance, variance);
                }
            }

            return maxVariance;
        }
    }
}