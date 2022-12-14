namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/ransom-note/
    /// </summary>
    public class Easy383_RansomNote
    {
        public bool CanConstruct(string ransomNote
            , string magazine)
        {
            var counts = new int[26];

            for (var i = 0; i < magazine.Length; i++)
            {
                counts[magazine[i] - 'a']++;
            }

            for (var i = 0; i < ransomNote.Length; i++)
            {
                counts[ransomNote[i] - 'a']--;

                if (counts[ransomNote[i] - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}