using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/lru-cache/
    /// </summary>
    public class Medium146_LRUCache
    {
        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */
        public class LRUCache
        {
            private readonly int _capacity;
            private readonly Dictionary<int, LinkedListNode<CacheItem>> _cache;
            private readonly LinkedList<CacheItem> _cacheList;

            public LRUCache(int capacity)
            {
                _capacity = capacity;
                _cache = new Dictionary<int, LinkedListNode<CacheItem>>();
                _cacheList = new LinkedList<CacheItem>();
            }

            public int Get(int key)
            {
                if (!_cache.TryGetValue(key, out var node))
                {
                    return -1;
                }

                _cacheList.Remove(node);
                _cacheList.AddFirst(node);

                return node.Value.Value;
            }

            public void Put(int key, int value)
            {
                if (_cache.TryGetValue(key, out var node))
                {
                    node.Value.Value = value;
                    _cacheList.Remove(node);
                    _cacheList.AddFirst(node);
                }
                else
                {
                    if (_cache.Count == _capacity)
                    {
                        var last = _cacheList.Last;
                        _cache.Remove(last.Value.Key);
                        _cacheList.RemoveLast();
                    }

                    var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
                    _cache.Add(key, newNode);
                    _cacheList.AddFirst(newNode);
                }
            }

            private class CacheItem
            {
                public int Key { get; }
                public int Value { get; set; }

                public CacheItem(int key, int value)
                {
                    Key = key;
                    Value = value;
                }
            }
        }
    }
}