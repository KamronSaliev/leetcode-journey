namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/integer-to-roman/
    /// </summary>
    public class Medium12_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var m = new[] { "", "M", "MM", "MMM" };
            var c = new[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            var x = new[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            var i = new[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return m[num / 1000] + c[num / 100 % 10] + x[num / 10 % 10] + i[num % 10];
        }
    }
}