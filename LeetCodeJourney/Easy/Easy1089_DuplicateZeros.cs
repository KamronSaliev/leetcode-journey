namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/duplicate-zeros/
    /// </summary>
    public class Easy1089_DuplicateZeros
    {
        public void DuplicateZeros(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != 0)
                {
                    continue;
                }

                for (var j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }

                i++;
            }
        }
    }
}