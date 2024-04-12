namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/trapping-rain-water
    /// </summary>
    public class Hard42_TrappingRainWater
    {
        public int Trap(int[] height)
        {
            var total = 0;
            var maxPeak = 0;
            var currentPeak = 0;

            for (var i = 0; i < height.Length; i++)
            {
                if (height[i] > maxPeak)
                {
                    maxPeak = height[i];
                }

                if (height[i] > currentPeak)
                {
                    currentPeak = height[i];
                }
                else if (height[i] < currentPeak)
                {
                    total += currentPeak - height[i];
                }
            }

            currentPeak = 0;

            for (var i = height.Length - 1; i >= 0; i--)
            {
                if (height[i] == maxPeak)
                {
                    break;
                }

                if (height[i] > currentPeak)
                {
                    currentPeak = height[i];
                }

                total -= maxPeak - currentPeak;
            }

            return total;
        }
    }
}