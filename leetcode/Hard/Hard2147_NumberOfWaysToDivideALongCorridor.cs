namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-ways-to-divide-a-long-corridor/
    /// </summary>
    public class Hard2147_NumberOfWaysToDivideALongCorridor
    {
        public int NumberOfWays(string corridor)
        {
            const long mod = (long)1e9 + 7;

            var result = 1L;
            var seatCount = 0L;
            var recentPosition = 0L;

            for (var i = 0; i < corridor.Length; ++i)
            {
                if (corridor[i] != 'S')
                {
                    continue;
                }

                seatCount++;

                if (seatCount > 2 && seatCount % 2 == 1)
                {
                    result = result * (i - recentPosition) % mod;
                }

                recentPosition = i;
            }

            return seatCount % 2 == 0 && seatCount > 0 ? (int)result : 0;
        }
    }
}