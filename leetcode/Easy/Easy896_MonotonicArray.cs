namespace LeetCode.Easy
{
    public class Easy896_MonotonicArray
    {
        public bool IsMonotonic(int[] nums)
        {
            var increasing = true;
            var decreasing = true;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    increasing = false;
                }

                if (nums[i] > nums[i - 1])
                {
                    decreasing = false;
                }
            }

            return increasing || decreasing;
        }
    }
}