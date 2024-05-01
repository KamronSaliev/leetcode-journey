using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-prefix-of-word
    /// </summary>
    public class Easy2000_ReversePrefixOfWord
    {
        public string ReversePrefix(string word, char ch)
        {
            var result = new StringBuilder();

            if (word.Contains(ch))
            {
                var index = word.IndexOf(ch);

                for (var i = index; i >= 0; i--)
                {
                    result.Append(word[i]);
                }

                result.Append(word[(index + 1)..]);
            }
            else
            {
                return word;
            }

            return result.ToString();
        }
    }
}