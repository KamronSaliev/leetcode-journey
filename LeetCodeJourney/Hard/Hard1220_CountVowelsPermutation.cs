namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/count-vowels-permutation/
    /// </summary>
    public class Hard1220_CountVowelsPermutation
    {
        public int CountVowelPermutation(int n)
        {
            const int mod = (int)(1e9 + 7);

            long a = 1, e = 1, i = 1, o = 1, u = 1;

            for (var j = 1; j < n; j++)
            {
                var aNext = e;
                var eNext = (a + i) % mod;
                var iNext = (a + e + o + u) % mod;
                var oNext = (i + u) % mod;
                var uNext = a;

                a = aNext;
                e = eNext;
                i = iNext;
                o = oNext;
                u = uNext;
            }

            return (int)((a + e + i + o + u) % mod);
        }
    }
}