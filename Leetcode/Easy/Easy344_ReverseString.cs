namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-string/
    /// </summary>
    public class Easy344_ReverseString
    {
        public void ReverseString(char[] s)
        {
            var l = 0;
            var r = s.Length - 1;

            while (l < r)
            {
                (s[l], s[r]) = (s[r], s[l]);

                l++;
                r--;
            }
        }
    }
}