namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-ways-to-form-a-target-string-given-a-dictionary/
    /// </summary>
    public class Hard1639_NumberOfWaysToFormATargetStringGivenADictionary
    {
        public int NumWays(string[] words, string target)
        {
            var alphabet = 26;
            var mod = (int)1e9 + 7;
            var m = target.Length;
            var k = words[0].Length;
            var count = new int[alphabet, k];

            for (var j = 0; j < k; j++)
            {
                foreach (var word in words)
                {
                    count[word[j] - 'a', j]++;
                }
            }

            var dp = new long[m + 1, k + 1];
            dp[0, 0] = 1;

            for (var i = 0; i <= m; i++)
            {
                for (var j = 0; j < k; j++)
                {
                    if (i < m)
                    {
                        dp[i + 1, j + 1] += count[target[i] - 'a', j] * dp[i, j];
                        dp[i + 1, j + 1] %= mod;
                    }

                    dp[i, j + 1] += dp[i, j];
                    dp[i, j + 1] %= mod;
                }
            }

            return (int)dp[m, k];
        }
    }
}