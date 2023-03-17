using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/implement-trie-prefix-tree/
    /// </summary>
    public class Medium208_ImplementTrie
    {
        /**
         * Your Trie object will be instantiated and called as such:
         * Trie obj = new Trie();
         * obj.Insert(word);
         * bool param_2 = obj.Search(word);
         * bool param_3 = obj.StartsWith(prefix);
         */
        public class Trie
        {
            private readonly TrieNode _root = new();

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
                
                foreach (var c in word)
                {
                    if (!current.Children.TryGetValue(c, out var childNode))
                    {
                        return false;
                    }

                    current = childNode;
                }

                return current.WasInserted;
            }

            public bool StartsWith(string prefix)
            {
                var current = _root;
                
                foreach (var c in prefix)
                {
                    if (!current.Children.TryGetValue(c, out var child))
                    {
                        return false;
                    }

                    current = child;
                }

                return true;
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