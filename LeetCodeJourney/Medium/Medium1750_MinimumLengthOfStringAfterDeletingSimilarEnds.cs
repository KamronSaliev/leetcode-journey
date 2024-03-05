namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends/
    /// </summary>
    public class Medium1750_MinimumLengthOfStringAfterDeletingSimilarEnds
    {
        public int MinimumLength(string s)
        {
            var l = 0;
            var r = s.Length - 1;

            while (l < r && s[l] == s[r])
            {
                var ch = s[l];

                while (l <= r && s[l] == ch)
                {
                    l++;
                }

                while (l <= r && s[r] == ch)
                {
                    r--;
                }
            }

            return r - l + 1;
        }
    }
}