using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/removing-stars-from-a-string/
    /// </summary>
    public class Medium2390_RemovingStarsFromAString
    {
        public string RemoveStars(string s)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}