namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/permutation-in-string/
    /// </summary>
    public class Medium567_PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }

            var count = new int[26];

            for (var i = 0; i < s1.Length; i++)
            {
                count[s1[i] - 'a']++;
            }

            for (var i = 0; i < s2.Length; i++)
            {
                count[s2[i] - 'a']--;

                if (i - s1.Length >= 0)
                {
                    count[s2[i - s1.Length] - 'a']++;
                }

                if (CheckZero(count))
                {
                    return true;
                }
            }


            return false;
        }

        private bool CheckZero(int[] count)
        {
            for (var i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}