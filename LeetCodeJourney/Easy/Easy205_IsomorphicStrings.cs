namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/isomorphic-strings/
    /// </summary>
    public class Easy205_IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            var map1 = new int[256];
            var map2 = new int[256];

            for (var i = 0; i < s.Length; i++)
            {
                if (map1[s[i]] != map2[t[i]])
                {
                    return false;
                }

                map1[s[i]] = i + 1;
                map2[t[i]] = i + 1;
            }

            return true;
        }
    }
}