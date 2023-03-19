using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/design-add-and-search-words-data-structure/
    /// </summary>
    public class Medium211_DesignAddAndSearchWordsDataStructure
    {
        /**
         * Your WordDictionary object will be instantiated and called as such:
         * WordDictionary obj = new WordDictionary();
         * obj.AddWord(word);
         * bool param_2 = obj.Search(word);
         */
        public class WordDictionary
        {
            private readonly Trie _wordTree;

            public WordDictionary()
            {
                _wordTree = new Trie();
            }

            public void AddWord(string word)
            {
                _wordTree.Insert(word);
            }

            public bool Search(string word)
            {
                return _wordTree.Search(word);
            }

            private class Trie
            {
                private readonly TrieNode _root = new();

                private const char Dot = '.';

                public void Insert(string word)
                {
                    var current = _root;
                    foreach (var c in word)
                    {
                        if (!current.Children.TryGetValue(c, out var childNode))
                        {
                            current.Children[c] = childNode = new TrieNode();
                        }

                        current = childNode;
                    }

                    current.WasInserted = true;
                }

                public bool Search(string word)
                {
                    var current = _root;
                    return SearchInternal(word, 0, current);
                }

                private bool SearchInternal(string word, int index, TrieNode current)
                {
                    if (index == word.Length)
                    {
                        return current.WasInserted;
                    }

                    var ch = word[index];

                    if (ch != Dot)
                    {
                        return current.Children.ContainsKey(ch) &&
                               SearchInternal(word, index + 1, current.Children[ch]);
                    }

                    var found = false;
                    foreach (var tempChild in current.Children.Values)
                    {
                        if (SearchInternal(word, index + 1, tempChild))
                        {
                            found = true;
                            break;
                        }
                    }

                    return found;
                }

                private class TrieNode
                {
                    public bool WasInserted { get; set; }

                    public Dictionary<char, TrieNode> Children { get; }

                    public TrieNode()
                    {
                        Children = new Dictionary<char, TrieNode>();
                    }
                }
            }
        }
    }
}