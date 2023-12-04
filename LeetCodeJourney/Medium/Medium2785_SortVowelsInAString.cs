using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-vowels-in-a-string/
    /// </summary>
    public class Medium2785_SortVowelsInAString
    {
        public string SortVowels(string s)
        {
            var characters = s.ToCharArray();
            var vowels = new List<char>();

            foreach (var character in characters)
            {
                if (IsVowel(character))
                {
                    vowels.Add(character);
                }
            }

            vowels.Sort();

            var vowelIndex = 0;

            for (var i = 0; i < characters.Length; i++)
            {
                if (IsVowel(characters[i]))
                {
                    characters[i] = vowels[vowelIndex++];
                }
            }

            return new string(characters);
        }

        private bool IsVowel(char character)
        {
            return char.ToLower(character) is 'a' or 'e' or 'i' or 'o' or 'u';
        }
    }
}