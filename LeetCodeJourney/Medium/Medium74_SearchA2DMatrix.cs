namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/search-a-2d-matrix/
    /// </summary>
    public class Medium74_SearchA2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;

            var start = 0;
            var end = n * m - 1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                var value = matrix[mid / m][mid % m];

                if (target == value)
                {
                    return true;
                }

                if (target < value)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return false;
        }
    }
}