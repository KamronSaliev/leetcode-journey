namespace LeetCode.Utilities
{
    public class DisjointSetUnion
    {
        public int Count { get; set; }

        private readonly int[] _parents;
        private readonly int[] _ranks;

        public DisjointSetUnion(int n)
        {
            _parents = new int[n];
            _ranks = new int[n];

            Count = n;

            for (var i = 0; i < n; i++)
            {
                _parents[i] = i;
                _ranks[i] = 1;
            }
        }

        public bool IsSameComponent(int u, int v)
        {
            return Find(u) == Find(v);
        }

        public int Find(int x)
        {
            var setX = _parents[x] == x ? x : Find(_parents[x]);
            _parents[x] = setX;
            return setX;
        }

        public bool Union(int x, int y)
        {
            var setX = Find(x);
            var setY = Find(y);

            if (setX == setY)
            {
                return false;
            }

            if (_ranks[setX] < _ranks[setY])
            {
                _parents[setX] = setY;
            }
            else if (_ranks[setX] > _ranks[setY])
            {
                _parents[setX] = setY;
            }
            else
            {
                _parents[setX] = setY;
                _ranks[setX]++;
            }

            Count--;

            return true;
        }
    }
}