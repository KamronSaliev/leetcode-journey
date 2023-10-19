namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/backspace-string-compare/
    /// </summary>
    public class Easy844_BackspaceStringCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            return ProcessString(s) == ProcessString(t);
        }

        private string ProcessString(string s)
        {
            var processedString = string.Empty;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '#' && processedString.Length > 0)
                {
                    processedString = processedString.Remove(processedString.Length - 1, 1);
                }
                else if (s[i] != '#')
                {
                    processedString += s[i];
                }
            }

            return processedString;
        }
    }
}