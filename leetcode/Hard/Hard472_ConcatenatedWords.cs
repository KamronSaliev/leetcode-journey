using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/concatenated-words/
    ///     https://leetcode.com/problems/concatenated-words/solutions/3103683/simple-dp-c-approach/
    /// </summary>
    public class Hard472_ConcatenatedWords
    {
        private HashSet<string> _dictionary;
        private HashSet<string> _formedWords;

        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            _dictionary = new HashSet<string>(words);
            _formedWords = new HashSet<string>();
            return words.Where(IsConcatenated).ToList();
        }

        private bool IsConcatenated(string word)
        {
            if (_formedWords.Contains(word))
            {
                return true;
            }

            for (var i = 1; i < word.Length; i++)
            {
                var s1 = word[..i];
                var s2 = word[i..];

                if (!_dictionary.Contains(s1) || !_dictionary.Contains(s2) && !IsConcatenated(s2))
                {
                    continue;
                }

                _formedWords.Add(word);
                
                return true;
            }

            return false;
        }
    }
}