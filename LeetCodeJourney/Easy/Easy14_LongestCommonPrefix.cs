namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class Easy14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var minLengthString = GetMinLengthString(strs);
            var lcp = "";

            for (var i = 0; i < minLengthString.Length; i++)
            {
                for (var j = 1; j <= minLengthString.Length - i; j++)
                {
                    var substring = minLengthString.Substring(i, j);

                    if (ContainsSubstring(strs, substring) && lcp.Length < substring.Length)
                    {
                        lcp = substring;
                    }
                }
            }

            return lcp;
        }

        private bool ContainsSubstring(string[] strs, string substring)
        {
            for (var i = 0; i < strs.Length; i++)
            {
                for (var j = 0; j < substring.Length; j++)
                {
                    if (strs[i][j] != substring[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private string GetMinLengthString(string[] strs)
        {
            var minLengthString = "";
            var minLength = int.MaxValue;

            for (var i = 0; i < strs.Length; i++)
            {
                if (minLength > strs[i].Length)
                {
                    minLengthString = strs[i];
                    minLength = strs[i].Length;
                }
            }

            return minLengthString;
        }
    }
}