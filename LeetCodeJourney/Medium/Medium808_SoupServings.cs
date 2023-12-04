using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/soup-servings/
    /// </summary>
    public class Medium808_SoupServings
    {
        private Dictionary<(int, int), double> _dp;

        private readonly List<(int serveA, int serveB)> _serveOperations = new()
        {
            (100, 0),
            (75, 25),
            (50, 50),
            (25, 75)
        };

        public double SoupServings(int n)
        {
            if (n > 4451)
            {
                return 1.0;
            }

            _dp = new Dictionary<(int, int), double>();
            return CalculateProbability(n, n);
        }

        private double CalculateProbability(int a, int b)
        {
            if (a <= 0 && b <= 0)
            {
                return 0.5;
            }

            if (a <= 0)
            {
                return 1.0;
            }

            if (b <= 0)
            {
                return 0.0;
            }

            if (_dp.ContainsKey((a, b)))
            {
                return _dp[(a, b)];
            }

            var total = 0.0d;

            foreach (var (serveA, serveB) in _serveOperations)
            {
                var x = a - serveA;
                var y = b - serveB;
                total += CalculateProbability(x, y);
            }

            return _dp[(a, b)] = total / 4;
        }
    }
}