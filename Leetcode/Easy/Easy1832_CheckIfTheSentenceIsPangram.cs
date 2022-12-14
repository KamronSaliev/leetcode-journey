namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-the-sentence-is-pangram/
    /// </summary>
    public class Easy1832_CheckIfTheSentenceIsPangram
    {
        public bool CheckIfPangram(string sentence)
        {
            var occurence = new bool[26];

            for (var i = 0; i < sentence.Length; i++)
            {
                occurence[sentence[i] - 'a'] = true;
            }

            for (var i = 0; i < occurence.Length; i++)
            {
                if (!occurence[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}