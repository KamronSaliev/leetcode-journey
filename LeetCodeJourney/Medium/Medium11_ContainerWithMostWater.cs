using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public class Medium11_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var left = 0;
            var right = height.Length - 1;
            var max = 0;

            while (left < right)
            {
                max = Math.Max(max, (right - left) * Math.Min(height[left], height[right]));
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return max;
        }
    }
}