using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/
    /// </summary>
    public class Easy1160_FindWordsThatCanBeFormedByCharacters
    {
        private Dictionary<char, int> CountCharacters(string s)
        {
            var characterCounts = new Dictionary<char, int>();
            
            foreach (var character in s)
            {
                if (!characterCounts.TryAdd(character, 1))
                {
                    characterCounts[character]++;
                }
            }

            return characterCounts;
        }

        public int CountCharacters(string[] words, string chars)
        {
            var charsCount = CountCharacters(chars);
            var result = 0;

            foreach (var word in words)
            {
                var wordCount = CountCharacters(word);
                
                if (CanFormWord(wordCount, charsCount))
                {
                    result += word.Length;
                }
            }

            return result;
        }

        private bool CanFormWord(Dictionary<char, int> wordCount, Dictionary<char, int> charsCount)
        {
            foreach (var pair in wordCount)
            {
                if (!charsCount.ContainsKey(pair.Key) || charsCount[pair.Key] < pair.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}