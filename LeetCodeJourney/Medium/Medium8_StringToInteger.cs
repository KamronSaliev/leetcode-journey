namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/string-to-integer-atoi/
    /// </summary>
    public class Medium8_StringToInteger
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart();

            var result = 0;
            var i = 0;
            var sign = 1;

            if (s.Length == 0)
            {
                return result;
            }
        
            if (s[i] == '-' || s[i] == '+')
            {
                sign = 1 - 2 * (s[i++] == '-' ? 1 : 0);
            }

            while(i < s.Length && char.IsDigit(s[i]))
            {
                var digit = s[i] - '0';

                if (result > int.MaxValue / 10 || result == int.MaxValue / 10 && digit > 7)
                {
                    return sign == -1 ? int.MinValue : int.MaxValue;
                }
            
                result = result * 10 + digit;
                i++;
            }

            return result * sign;
        }
    }
}