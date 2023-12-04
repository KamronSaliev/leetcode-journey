namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/restore-the-array/
    /// </summary>
    public class Hard1416_RestoreTheArray
    {
        public int NumberOfArrays(string s, int k)
        {
            var n = s.Length;
            var dp = new long[n + 1];
            dp[n] = 1;
            
            for (var i = n - 1; i >= 0; i--)
            {
                if (s[i] == '0')
                {
                    dp[i] = 0;
                }
                else
                {
                    long num = 0;
                    for (var j = i; j < n; j++)
                    {
                        num = num * 10 + (s[j] - '0');
                        if (num > k)
                        {
                            break;
                        }

                        dp[i] = (dp[i] + dp[j + 1]) % (int)(1e9 + 7);
                    }
                }
            }

            return (int)dp[0];
        }
    }
}