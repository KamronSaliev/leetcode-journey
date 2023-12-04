using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/add-to-array-form-of-integer/
    /// </summary>
    public class Easy989_AddToArrayFormOfInteger
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            var result = new List<int>();
            var carry = 0;
            var i = num.Length - 1;

            while (i >= 0 || k > 0)
            {
                var sum = carry;

                if (i >= 0)
                {
                    sum += num[i];
                }

                if (k > 0)
                {
                    sum += k % 10;
                }

                carry = sum >= 10 ? 1 : 0;
                result.Add(sum % 10);

                k /= 10;
                i--;
            }

            if (carry != 0)
            {
                result.Add(carry);
            }

            result.Reverse();

            return result;
        }
    }
}