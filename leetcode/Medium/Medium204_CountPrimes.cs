namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-primes/
    /// </summary>
    public class Medium204_CountPrimes
    {
        public int CountPrimes(int n)
        {
            var count = 0;
            var isComposite = new bool[n + 1];

            for (var i = 2; i < n; i++)
            {
                if (isComposite[i])
                {
                    continue;
                }

                count++;

                for (var j = i * 2; j < n; j += i)
                {
                    isComposite[j] = true;
                }
            }

            return count;
        }
    }
}