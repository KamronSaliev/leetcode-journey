using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-unique-binary-string/
    /// </summary>
    public class Medium1980_FindUniqueBinaryString
    {
        public string FindDifferentBinaryString(string[] nums)
        {
            var result = new StringBuilder();

            for (var i = 0; i < nums.Length; i++)
            {
                result.Append(nums[i][i] == '0' ? '1' : '0');
            }

            return result.ToString();
        }
    }
}