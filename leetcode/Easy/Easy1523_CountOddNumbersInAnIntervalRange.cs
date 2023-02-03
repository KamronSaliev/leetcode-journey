namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
    /// </summary>
    public class Easy1523_CountOddNumbersInAnIntervalRange
    {
        public int CountOdds(int low, int high)
        {
            var temp = (high - low) / 2;
            
            if (high % 2 == 0 && low % 2 == 0)
            {
                return temp;
            }

            return temp + 1;
        }
    }
}