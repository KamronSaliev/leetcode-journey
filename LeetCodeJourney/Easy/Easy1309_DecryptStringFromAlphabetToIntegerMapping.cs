namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
    /// </summary>
    public class Easy1309_DecryptStringFromAlphabetToIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            var reverse = string.Empty;

            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '#')
                {
                    reverse += (char)(int.Parse(s[i - 2] + s[i - 1].ToString()) + 96);
                    i -= 2;
                }
                else
                {
                    reverse += (char)(int.Parse(s[i].ToString()) + 96);
                }
            }

            var result = string.Empty;

            for (var i = reverse.Length - 1; i >= 0; i--)
            {
                result += reverse[i];
            }

            return result;
        }
    }
}