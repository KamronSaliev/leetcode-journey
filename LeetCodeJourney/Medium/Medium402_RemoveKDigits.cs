using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-k-digits
    /// </summary>
    public class Medium402_RemoveKDigits
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == num.Length)
            {
                return "0";
            }

            var sb = new StringBuilder();

            foreach (var digit in num)
            {
                while (k > 0 && sb.Length > 0 && sb[^1] > digit)
                {
                    sb.Length--;
                    k--;
                }

                sb.Append(digit);
            }

            sb.Length -= k;
            var result = sb.ToString().TrimStart('0');
            return result.Length == 0 ? "0" : result;
        }
    }
}