using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    public class Medium54_SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var result = new List<int>();

            var topIndex = 0;
            var bottomIndex = matrix.Length - 1;
            var leftIndex = 0;
            var rightIndex = matrix[0].Length - 1;
            var direction = 0;

            while (topIndex <= bottomIndex && leftIndex <= rightIndex)
            {
                switch (direction)
                {
                    case 0:
                        for (var i = leftIndex; i <= rightIndex; i++)
                        {
                            result.Add(matrix[topIndex][i]);
                        }

                        topIndex++;
                        break;
                    case 1:
                        for (var i = topIndex; i <= bottomIndex; i++)
                        {
                            result.Add(matrix[i][rightIndex]);
                        }

                        rightIndex--;
                        break;
                    case 2:
                        for (var i = rightIndex; i >= leftIndex; i--)
                        {
                            result.Add(matrix[bottomIndex][i]);
                        }

                        bottomIndex--;
                        break;
                    case 3:
                        for (var i = bottomIndex; i >= topIndex; i--)
                        {
                            result.Add(matrix[i][leftIndex]);
                        }

                        leftIndex++;
                        break;
                }

                direction = (direction + 1) % 4;
            }

            return result;
        }
    }
}