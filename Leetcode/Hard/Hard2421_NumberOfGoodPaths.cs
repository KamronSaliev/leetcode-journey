using System;

namespace Leetcode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-good-paths/
    ///     https://leetcode.com/problems/number-of-good-paths/solutions/2892908/number-of-good-paths/?orderBy=most_votes
    /// </summary>
    public class Hard2421_NumberOfGoodPaths
    {
        private int[] _parents, _count, _vals;
        private int _result;

        public int NumberOfGoodPaths(int[] vals, int[][] edges)
        {
            _vals = vals;

            Array.Sort(edges, (a, b) => Math.Max(vals[a[0]], vals[a[1]]) - Math.Max(vals[b[0]], vals[b[1]]));

            _result = vals.Length;
            _parents = new int[vals.Length];

            for (var i = 0; i < vals.Length; i++)
            {
                _parents[i] = i;
            }

            _count = new int[vals.Length];
            foreach (var edge in edges)
            {
                Union(edge[0], edge[1]);
            }

            return _result;
        }

        private void Union(int a, int b)
        {
            var pa = Parent(a);
            var pb = Parent(b);

            if (pa == pb)
            {
                return;
            }

            if (_vals[pa] == _vals[pb])
            {
                _result += (_count[pa] + 1) * (_count[pb] + 1);
                _count[pa] += _count[pb] + 1;
                _parents[pb] = pa;
            }
            else if (_vals[pa] > _vals[pb])
            {
                _parents[pb] = pa;
            }
            else
            {
                _parents[pa] = pb;
            }
        }

        private int Parent(int a)
        {
            int p;

            if ((p = _parents[a]) != a)
            {
                p = _parents[a] = Parent(p);
            }

            return p;
        }
    }
}