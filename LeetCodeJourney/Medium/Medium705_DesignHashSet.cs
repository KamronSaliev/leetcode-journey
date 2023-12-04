using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/design-hashset/
    /// </summary>
    public class Medium705_DesignHashSet
    {
        /**
         * Your MyHashSet object will be instantiated and called as such:
         * MyHashSet obj = new MyHashSet();
         * obj.Add(key);
         * obj.Remove(key);
         * bool param_3 = obj.Contains(key);
         */
        public class MyHashSet
        {
            private readonly IList<int> _hashSet;

            public MyHashSet()
            {
                _hashSet = new List<int>();
            }

            public void Add(int key)
            {
                if (!_hashSet.Contains(key))
                {
                    _hashSet.Add(key);
                }
            }

            public void Remove(int key)
            {
                _hashSet.Remove(key);
            }

            public bool Contains(int key)
            {
                return _hashSet.Contains(key);
            }
        }
    }
}