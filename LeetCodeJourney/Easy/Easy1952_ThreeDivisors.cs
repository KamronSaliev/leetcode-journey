namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/three-divisors/
    /// </summary>
    public class Easy1952_ThreeDivisors
    {
        public bool IsThree(int n)
        {
            var result = 1;

            for (var i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    result++;
                }
            }

            return result == 3;
        }
    }
}