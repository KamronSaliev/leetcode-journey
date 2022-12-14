namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/determine-if-string-halves-are-alike/
    /// </summary>
    public class Easy1704_DetermineIfStringHalvesAreAlike
    {
        public bool HalvesAreAlike(string s)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            var lowered = s.ToLower();
            var counter = 0;

            for (var i = 0; i < lowered.Length; i++)
            {
                if (!CheckVowel(lowered[i], vowels))
                {
                    continue;
                }

                if (i < lowered.Length / 2)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }

            return counter == 0;
        }

        private bool CheckVowel(char c, char[] vowels)
        {
            for (var i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == c)
                {
                    return true;
                }
            }

            return false;
        }
    }
}