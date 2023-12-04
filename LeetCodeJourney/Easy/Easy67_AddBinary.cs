using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/add-binary/
    /// </summary>
    public class Easy67_AddBinary
    {
        public string AddBinary(string a, string b)
        {
            var result = new StringBuilder();
            var i = a.Length - 1;
            var j = b.Length - 1;
            var carry = 0;

            while (i >= 0 || j >= 0)
            {
                var sum = carry;
                
                if (i >= 0)
                {
                    sum += a[i--] - '0';
                }

                if (j >= 0)
                {
                    sum += b[j--] - '0';
                }

                carry = sum > 1 ? 1 : 0;
                result.Append(sum % 2);
            }

            if (carry != 0)
            {
                result.Append(carry);
            }

            var answer = new StringBuilder();
            for (var k = result.Length - 1; k >= 0; k--)
            {
                answer.Append(result[k]);
            }

            return answer.ToString();
        }
    }
}