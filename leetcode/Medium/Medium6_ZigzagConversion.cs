namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/zigzag-conversion/
    /// </summary>
    public class Medium6_ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            var str = new string[numRows];

            for (var i = 0; i < str.Length; i++)
            {
                str[i] = string.Empty;
            }

            var index = 0;

            while (index < s.Length)
            {
                for (var j = 0; j < numRows && index < s.Length; j++)
                {
                    str[j] += s[index++];
                }

                for (var j = numRows - 2; j > 0 && index < s.Length; j--)
                {
                    str[j] += s[index++];
                }
            }

            var result = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                result += str[i];
            }

            return result;
        }
    }
}