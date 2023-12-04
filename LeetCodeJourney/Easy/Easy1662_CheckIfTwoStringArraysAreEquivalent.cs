namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
    /// </summary>
    public class Easy1662_CheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return string.Concat(word1) == string.Concat(word2);
        }
    }
}