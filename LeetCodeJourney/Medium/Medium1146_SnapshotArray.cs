using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/snapshot-array/
    /// </summary>
    public class Medium1146_SnapshotArray
    {
        /**
         * Your SnapshotArray object will be instantiated and called as such:
         * SnapshotArray obj = new SnapshotArray(length);
         * obj.Set(index,val);
         * int param_2 = obj.Snap();
         * int param_3 = obj.Get(index,snap_id);
         */
        public class SnapshotArray
        {
            private readonly Dictionary<int, int>[] _snapshots;
            private int _snapId;

            public SnapshotArray(int length)
            {
                _snapshots = new Dictionary<int, int>[length];
                _snapId = 0;
            }

            public void Set(int index, int val)
            {
                _snapshots[index] ??= new Dictionary<int, int>();
                _snapshots[index][_snapId] = val;
            }

            public int Snap()
            {
                return _snapId++;
            }

            public int Get(int index, int snap_id)
            {
                var result = _snapshots[index];

                if (result == null)
                {
                    return 0;
                }

                if (result.TryGetValue(snap_id, out var val))
                {
                    return val;
                }

                var arr = result.Select(k => (k.Key, k.Value)).ToArray();
                var left = 0;
                var right = arr.Length - 1;
                
                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    var (snap, value) = arr[mid];
                    
                    if (snap < snap_id)
                    {
                        val = value;
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return val;
            }
        }
    }
}