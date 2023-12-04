namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-smallest-letter-greater-than-target/
    /// </summary>
    public class Easy744_FindSmallestLetterGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            var left = 0;
            var right = letters.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (target < letters[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return letters[left % letters.Length];
        }
    }
}