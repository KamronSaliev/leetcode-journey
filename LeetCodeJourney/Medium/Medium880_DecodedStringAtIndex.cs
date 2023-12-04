namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/decoded-string-at-index/
    /// </summary>
    public class Medium880_DecodedStringAtIndex
    {
        public string DecodeAtIndex(string s, int k)
        {
            var index = 0;
            var length = 0L;

            while (length < k)
            {
                if (char.IsDigit(s[index]))
                {
                    length *= s[index] - '0';
                }
                else
                {
                    length++;
                }

                index++;
            }

            var result = string.Empty;

            for (var i = index - 1; i >= 0; i--)
            {
                if (char.IsDigit(s[i]))
                {
                    length /= s[i] - '0';
                    k %= (int)length;
                }
                else
                {
                    if (k == 0 || k == length)
                    {
                        result = s[i].ToString();
                        break;
                    }

                    length--;
                }
            }

            return result;
        }
    }
}