namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-replacements-to-sort-the-array/
    /// </summary>
    public class Hard2366_MinimumReplacementsToSortTheArray
    {
        public long MinimumReplacement(int[] nums)
        {
            long replacementsNumber = 0;
            long previousBound = nums[^1];

            for (var i = nums.Length - 2; i >= 0; i--)
            {
                var numberOfTimes = (nums[i] + previousBound - 1) / previousBound;
                replacementsNumber += numberOfTimes - 1;
                previousBound = nums[i] / numberOfTimes;
            }

            return replacementsNumber;
        }
    }
}