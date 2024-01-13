namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram/
    /// </summary>
    public class Medium1347_MinimumNumberOfStepsToMakeTwoStringsAnagram
    {
        public int MinSteps(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return -1;
            }

            var charCount = new int[26];
            var result = 0;

            foreach (var c in s)
            {
                charCount[c - 'a']++;
            }

            foreach (var c in t)
            {
                if (charCount[c - 'a'] == 0)
                {
                    result++;
                }
                else
                {
                    charCount[c - 'a']--;
                }
            }

            return result;
        }
    }
}