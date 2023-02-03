namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/to-lower-case/
    /// </summary>
    public class Easy709_ToLowerCase
    {
        public string ToLowerCase(string s)
        {
            var ans = string.Empty;

            for (var i = 0; i < s.Length; i++)
            {
                ans += char.ToLower(s[i]);
            }

            return ans;
        }
    }
}