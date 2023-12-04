using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/koko-eating-bananas/
    /// </summary>
    public class Medium875_KokoEatingBananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            var bounds = GetBounds(piles, h);
            var left = bounds.Item1;
            var right = bounds.Item2;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (CanEat(piles, mid, h))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private (int, int) GetBounds(int[] piles, int h)
        {
            var lowerBound = 0;
            var sum = 0;
            var upperBound = 0;
            
            for (var i = 0; i < piles.Length; i++)
            {
                sum += piles[i];
                upperBound = Math.Max(upperBound, piles[i]);
            }

            lowerBound = (int)Math.Ceiling((double)(sum / h));

            return (lowerBound, upperBound);
        }

        private bool CanEat(int[] piles, int k, int h)
        {
            var hours = 0d;

            for (var i = 0; i < piles.Length; i++)
            {
                hours += Math.Ceiling((double)piles[i] / k);
            }

            return hours <= h;
        }
    }
}