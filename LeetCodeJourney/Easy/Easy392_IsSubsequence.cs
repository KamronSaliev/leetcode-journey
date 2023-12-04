namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/is-subsequence/
    /// </summary>
    public class Easy392_IsSubsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            var counter = 0;

            for (var i = 0; i < t.Length && counter < s.Length; i++)
            {
                if (s[counter] == t[i])
                {
                    counter++;
                }
            }

            return counter == s.Length;
        }
    }
}