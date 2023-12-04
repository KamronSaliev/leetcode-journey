namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
    /// </summary>
    public class Easy1588_SumOfAllOddLengthSubarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            var sum = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i; j < arr.Length; j += 2)
                {
                    for (var k = i; k <= j; k++)
                    {
                        sum += arr[k];
                    }
                }
            }

            return sum;
        }
    }
}