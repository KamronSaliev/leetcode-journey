namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-odd-number-in-string/
    /// </summary>
    public class Easy1903_LargestOddNumberInString
    {
        public string LargestOddNumber(string num)
        {
            var result = string.Empty;

            for (var i = num.Length - 1; i >= 0; i--)
            {
                if ((num[i] - '0') % 2 != 0)
                {
                    return num[..(i + 1)];
                }
            }

            return result;
        }
    }
}