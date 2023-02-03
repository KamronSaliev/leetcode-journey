namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
    /// </summary>
    public class Easy1662_CheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var s1 = string.Empty;
            var s2 = string.Empty;

            for (var i = 0; i < word1.Length; i++)
            {
                s1 += word1[i];
            }

            for (var i = 0; i < word1.Length; i++)
            {
                s2 += word2[i];
            }

            return s1 == s2;
        }
    }
}