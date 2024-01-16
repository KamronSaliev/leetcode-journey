using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/insert-delete-getrandom-o1/
    /// </summary>
    public class Medium380_InsertDeleteGetRandom
    {
        public class RandomizedSet
        {
            private readonly HashSet<int> _hashSet = new();
            private readonly Random _random = new();

            public bool Insert(int val)
            {
                return _hashSet.Add(val);
            }

            public bool Remove(int val)
            {
                return _hashSet.Remove(val);
            }

            public int GetRandom()
            {
                return _hashSet.ElementAt(_random.Next(_hashSet.Count));
            }
        }
    }
}