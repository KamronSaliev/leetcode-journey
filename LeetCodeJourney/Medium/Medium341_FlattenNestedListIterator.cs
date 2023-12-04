using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/flatten-nested-list-iterator/
    /// </summary>
    public class Medium341_FlattenNestedListIterator
    {
        public class NestedIterator
        {
            private readonly List<int> _flatten;
            private int _index;

            public NestedIterator(IList<NestedInteger> nestedList)
            {
                _flatten = new List<int>();
                _flatten = Flatten(nestedList);
                _index = 0;
            }

            public bool HasNext()
            {
                return _index < _flatten.Count;
            }

            public int Next()
            {
                return _flatten[_index++];
            }

            private List<int> Flatten(IList<NestedInteger> nestedIntegers)
            {
                var result = new List<int>();

                for (var i = 0; i < nestedIntegers.Count; i++)
                {
                    if (nestedIntegers[i].IsInteger())
                    {
                        result.Add(nestedIntegers[i].GetInteger());
                    }
                    else
                    {
                        result.AddRange(Flatten(nestedIntegers[i].GetList()));
                    }
                }

                return result;
            }

            public interface NestedInteger
            {
                bool IsInteger();
                int GetInteger();
                IList<NestedInteger> GetList();
            }
        }
    }
}