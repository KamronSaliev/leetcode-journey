using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/valid-sudoku/
    /// </summary>
    public class Medium36_ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rowHashSet = new HashSet<char>[9];
            var columnHashSet = new HashSet<char>[9];
            var gridHashSet = new HashSet<char>[9];

            for (var i = 0; i < 9; i++)
            {
                rowHashSet[i] = new HashSet<char>();
                columnHashSet[i] = new HashSet<char>();
                gridHashSet[i] = new HashSet<char>();
            }

            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }

                    var index = i / 3 * 3 + j / 3;

                    if (!rowHashSet[i].Add(board[i][j]) ||
                        !columnHashSet[j].Add(board[i][j]) ||
                        !gridHashSet[index].Add(board[i][j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}