namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-trailing-zeros-from-a-string/
    /// </summary>
    public class Easy2710_RemoveTrailingZerosFromAString
    {
        public string RemoveTrailingZeros(string num)
        {
            return num.TrimEnd('0');
        }
    }
}