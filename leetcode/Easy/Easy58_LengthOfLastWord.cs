namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public class Easy58_LengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            var counter = 0;

            var endIndex = s.Length - 1;

            while (s[endIndex] == ' ')
            {
                endIndex--;
            }

            while (endIndex >= 0 && s[endIndex] != ' ')
            {
                counter++;
                endIndex--;
            }

            return counter;
        }
    }
}