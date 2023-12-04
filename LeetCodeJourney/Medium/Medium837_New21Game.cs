namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/new-21-game/
    /// </summary>
    public class Medium837_New21Game
    {
        public double New21Game(int n, int k, int maxPts)
        {
            if (k == 0 || k + maxPts <= n)
            {
                return 1.0;
            }

            var nums = new double[n + 1];
            var sum = 1.0;
            var result = 0.0;
            nums[0] = 1;
            
            for (var i = 1; i < nums.Length; i++)
            {
                nums[i] = sum / maxPts;
                if (i < k)
                {
                    sum += nums[i];
                }
                else
                {
                    result += nums[i];
                }

                if (i - maxPts >= 0)
                {
                    sum = sum - nums[i - maxPts];
                }
            }

            return result;
        }
    }
}