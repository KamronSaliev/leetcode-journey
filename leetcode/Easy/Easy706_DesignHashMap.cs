namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/design-hashmap/
    /// </summary>
    public class Easy706_DesignHashMap
    {
        public class MyHashMap
        {
            private readonly ListKeyValueNode[] _map;

            private const int Size = 10000;

            public MyHashMap()
            {
                _map = new ListKeyValueNode[Size];
            }

            private int Hash(int key)
            {
                return key % _map.Length;
            }

            public void Put(int key, int value)
            {
                var index = Hash(key);
                var current = _map[index];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        current.Value = value;
                        return;
                    }

                    current = current.Next;
                }

                _map[index] = new ListKeyValueNode(key, value, _map[index]);
            }

            public int Get(int key)
            {
                var index = Hash(key);
                var current = _map[index];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return current.Value;
                    }

                    current = current.Next;
                }

                return -1;
            }

            public void Remove(int key)
            {
                var index = Hash(key);
                ListKeyValueNode previous = null;
                var current = _map[index];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        if (previous != null)
                        {
                            previous.Next = current.Next;
                        }
                        else
                        {
                            _map[index] = current.Next;
                        }
                    }

                    previous = current;
                    current = current.Next;
                }
            }

            private class ListKeyValueNode
            {
                public readonly int Key;
                public int Value;
                public ListKeyValueNode Next;

                public ListKeyValueNode(int key = -1, int val = 0, ListKeyValueNode next = null)
                {
                    Key = key;
                    Value = val;
                    Next = next;
                }
            }
        }
    }
}