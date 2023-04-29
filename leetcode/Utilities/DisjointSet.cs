namespace LeetCode.Utilities
{
    public class DisjointSet
    {
        private readonly int[] _parent;
        private readonly int[] _rank;

        public DisjointSet(int n)
        {
            _parent = new int[n];
            _rank = new int[n];
            for (var i = 0; i < n; i++)
            {
                _parent[i] = i;
            }
        }

        public int Find(int x)
        {
            var setX = _parent[x] == x ? x : Find(_parent[x]);
            _parent[x] = setX;
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

            if (_rank[setX] < _rank[setY])
            {
                _parent[setX] = setY;
            }
            else if (_rank[setX] > _rank[setY])
            {
                _parent[setX] = setY;
            }
            else
            {
                _parent[setX] = setY;
                _rank[setX]++;
            }

            return true;
        }
    }
}