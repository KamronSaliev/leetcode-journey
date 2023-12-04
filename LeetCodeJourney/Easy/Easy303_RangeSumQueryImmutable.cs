namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/range-sum-query-immutable/
    /// </summary>
    public class Easy303_RangeSumQueryImmutable
    {
        /**
         * Your NumArray object will be instantiated and called as such:
         * NumArray obj = new NumArray(nums);
         * int param_1 = obj.SumRange(left,right);
         */
        public class NumArray
        {
            private readonly int[] _prefixSums;

            public NumArray(int[] nums)
            {
                _prefixSums = new int[nums.Length];
                _prefixSums[0] = nums[0];

                for (var i = 1; i < nums.Length; i++)
                {
                    _prefixSums[i] = _prefixSums[i - 1] + nums[i];
                }
            }

            public int SumRange(int left, int right)
            {
                if (left == 0)
                {
                    return _prefixSums[right];
                }

                return _prefixSums[right] - _prefixSums[left - 1];
            }
        }
    }
}