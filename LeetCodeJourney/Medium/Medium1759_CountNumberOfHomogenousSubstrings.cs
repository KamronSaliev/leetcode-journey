namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-number-of-homogenous-substrings/
    /// </summary>
    public class Medium1759_CountNumberOfHomogenousSubstrings
    {
        public int CountHomogenous(string s)
        {
            const int mod = (int)(1e9 + 7);

            var result = 0;
            var consecutive = 1L;

            for (var i = 1; i <= s.Length; i++)
            {
                if (i < s.Length && s[i] == s[i - 1])
                {
                    consecutive++;
                }
                else
                {
                    result = (int)((result + consecutive * (consecutive + 1) / 2) % mod);
                    consecutive = 1;
                }
            }

            return result;
        }
    }
}