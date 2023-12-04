namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-original-array-of-prefix-xor/
    /// </summary>
    public class Medium2433_FindTheOriginalArrayOfPrefixXor
    {
        public int[] FindArray(int[] pref)
        {
            var result = new int[pref.Length];
            result[0] = pref[0];

            for (var i = 1; i < pref.Length; i++)
            {
                result[i] = pref[i] ^ pref[i - 1];
            }

            return result;
        }
    }
}