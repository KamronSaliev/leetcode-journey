namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-wonderful-substrings
    /// </summary>
    public class Medium1915_NumberOfWonderfulSubstrings
    {
        public long WonderfulSubstrings(string word)
        {
            var result = 0L;
            var mask = 0;
            var count = new int[1024];
            count[0] = 1;

            foreach (var character in word)
            {
                mask ^= 1 << (character - 'a');
                result += count[mask];

                for (var i = 0; i < 10; i++)
                {
                    result += count[mask ^ (1 << i)];
                }

                count[mask]++;
            }

            return result;
        }
    }
}