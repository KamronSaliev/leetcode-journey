namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/first-unique-character-in-a-string/
    /// </summary>
    public class Easy387_FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            var occurences = new int[26];
            var index = -1;

            for (var i = 0; i < s.Length; i++)
            {
                occurences[s[i] - 'a']++;
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (occurences[s[i] - 'a'] != 1)
                {
                    continue;
                }

                index = i;
                break;
            }

            return index;
        }
    }
}