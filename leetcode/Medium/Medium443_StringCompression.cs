namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/string-compression/
    /// </summary>
    public class Medium443_StringCompression
    {
        public int Compress(char[] chars)
        {
            var i = 0;
            var j = 0;

            while (i < chars.Length)
            {
                var current = chars[i];
                var counter = 0;

                while (i < chars.Length && chars[i] == current)
                {
                    i++;
                    counter++;
                }

                chars[j++] = current;

                if (counter > 1)
                {
                    foreach (var counterChar in counter.ToString())
                    {
                        chars[j++] = counterChar;
                    }
                }
            }

            return j;
        }
    }
}