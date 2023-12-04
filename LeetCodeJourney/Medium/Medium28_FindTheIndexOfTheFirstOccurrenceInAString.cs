namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
    /// </summary>
    public class Medium28_FindTheIndexOfTheFirstOccurrenceInAString
    {
        public int StrStr(string haystack, string needle)
        {
            for (var i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}