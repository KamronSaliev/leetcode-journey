namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/add-digits/
    /// </summary>
    public class Easy258_AddDigits
    {
        public int AddDigits(int num)
        {
            var result = num;
            var sum = 0;

            while (result >= 10)
            {
                while (result != 0)
                {
                    sum += result % 10;
                    result /= 10;
                }

                result = sum;
                sum = 0;
            }

            return result;
        }
    }
}