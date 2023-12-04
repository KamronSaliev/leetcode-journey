using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/data-stream-as-disjoint-intervals/
    /// </summary>
    public class Hard352_DataStreamAsDisjointIntervals
    {
        /**
         * Your SummaryRanges object will be instantiated and called as such:
         * SummaryRanges obj = new SummaryRanges();
         * obj.AddNum(value);
         * int[][] param_2 = obj.GetIntervals();
         */
        
        public class SummaryRanges
        {
            private readonly SortedSet<int> _data;

            public SummaryRanges()
            {
                _data = new SortedSet<int>();
            }

            public void AddNum(int value)
            {
                _data.Add(value);
            }

            public int[][] GetIntervals()
            {
                if (_data.Count == 0)
                {
                    return Array.Empty<int[]>();
                }

                var intervals = new List<int[]>();
                int left = -1, right = -1;

                foreach (var value in _data)
                {
                    if (left < 0)
                    {
                        left = right = value;
                    }
                    else if (value == right + 1)
                    {
                        right = value;
                    }
                    else
                    {
                        intervals.Add(new[] { left, right });
                        left = right = value;
                    }
                }

                intervals.Add(new[] { left, right });
                return intervals.ToArray();
            }
        }
    }
}