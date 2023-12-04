using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/lfu-cache/
    /// </summary>
    public class Hard460_LFUCache
    {
        /**
         * Your LFUCache object will be instantiated and called as such:
         * LFUCache obj = new LFUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */
        
        public class LFUCache
        {
            private int _minFrequency;
            private readonly int _capacity;
            private readonly Dictionary<int, List<int>> _frequencies;
            private readonly Dictionary<int, (int Value, int Frequency)> _cache;

            public LFUCache(int capacity)
            {
                _capacity = capacity;
                _minFrequency = 0;
                _frequencies = new Dictionary<int, List<int>>();
                _cache = new Dictionary<int, (int Value, int Frequency)>();
            }

            // ReSharper disable once MemberCanBePrivate.Global
            public int Get(int key)
            {
                if (!_cache.ContainsKey(key))
                {
                    return -1;
                }

                var item = _cache[key];
                var itemFrequency = item.Frequency;
                var itemValue = item.Value;

                _frequencies[itemFrequency].Remove(key);

                if (_frequencies[itemFrequency].Count == 0 && _minFrequency == itemFrequency)
                {
                    _minFrequency++;
                }

                Insert(key, itemFrequency + 1, itemValue);

                return itemValue;
            }

            public void Put(int key, int value)
            {
                if (_capacity <= 0)
                {
                    return;
                }
                
                if (_cache.ContainsKey(key))
                {
                    _cache[key] = (value, _cache[key].Frequency);

                    Get(key);
                    return;
                }

                if (_cache.Count == _capacity)
                {
                    _cache.Remove(_frequencies[_minFrequency].First());
                    _frequencies[_minFrequency].RemoveAt(0);
                }

                _minFrequency = 1;

                Insert(key, _minFrequency, value);
            }

            private void Insert(int key, int frequency, int value)
            {
                if (!_frequencies.ContainsKey(frequency))
                {
                    _frequencies[frequency] = new List<int>();
                }

                _frequencies[frequency].Add(key);
                _cache[key] = (value, frequency);
            }
        }
    }
}