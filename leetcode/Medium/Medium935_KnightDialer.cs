using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/knight-dialer/
    /// </summary>
    public class Medium935_KnightDialer
    {
        public int KnightDialer(int n)
        {
            const long mod = (long)(1e9 + 7);

            var result = new long[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var temp = new long[10];

            for (var i = 1; i < n; i++)
            {
                for (var j = 0; j < temp.Length; j++)
                {
                    temp[j] = Get(j, result) % mod;
                }

                for (var j = 0; j < temp.Length; j++)
                {
                    result[j] = temp[j];
                }
            }

            return (int)(result.Sum() % mod);
        }

        private long Get(int n, long[] nums)
        {
            return n switch
            {
                0 => nums[4] + nums[6],
                1 => nums[6] + nums[8],
                2 => nums[7] + nums[9],
                3 => nums[4] + nums[8],
                4 => nums[3] + nums[9] + nums[0],
                5 => 0,
                6 => nums[1] + nums[7] + nums[0],
                7 => nums[2] + nums[6],
                8 => nums[1] + nums[3],
                9 => nums[2] + nums[4],
                _ => 0
            };
        }
    }
}