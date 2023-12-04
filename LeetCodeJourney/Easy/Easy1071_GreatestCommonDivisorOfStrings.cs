using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/greatest-common-divisor-of-strings/
    /// </summary>
    public class Easy1071_GreatestCommonDivisorOfStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return string.Empty;
            }

            var gcdLength = CommonUtilities.GCD(str1.Length, str2.Length);

            return str1[..gcdLength];
        }
    }
}