namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/detect-capital/
    /// </summary>
    public class Easy520_DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            var capitalCounter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    capitalCounter++;
                }
            }

            return capitalCounter == 0 || capitalCounter == word.Length ||
                   (capitalCounter == 1 && char.IsUpper(word[0]));
        }
    }
}