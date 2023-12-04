namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/excel-sheet-column-number/
    /// </summary>
    public class Easy171_ExcelSheetColumnNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            var result = 0;

            for (var i = 0; i < columnTitle.Length; i++)
            {
                var temp = columnTitle[i] - 'A' + 1;
                result = result * 26 + temp;
            }

            return result;
        }
    }
}