namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-lines-to-write-string/
    /// </summary>
    public class Easy806_NumberOfLinesToWriteString
    {
        public int[] NumberOfLines(int[] widths, string s)
        {
            var limit = 100;
            var numberOfLines = 1;
            var width = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var tempWidth = widths[s[i] - 'a'];

                if (width + tempWidth > limit)
                {
                    numberOfLines++;
                    width = 0;
                }

                width += tempWidth;
            }

            return new[] { numberOfLines, width };
        }
    }
}