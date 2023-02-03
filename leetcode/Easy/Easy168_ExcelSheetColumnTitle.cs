namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/excel-sheet-column-title/
    /// </summary>
    public class Easy168_ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            var result = string.Empty;

            while (columnNumber > 0)
            {
                columnNumber--;
                result = (char)(columnNumber % 26 + 'A') + result;
                columnNumber /= 26;
            }

            return result;
        }
    }
}