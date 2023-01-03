namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/delete-columns-to-make-sorted/
    /// </summary>
    public class Easy944_DeleteColumnsToMakeSorted
    {
        public int MinDeletionSize(string[] strs)
        {
            var counter = 0;

            for (var i = 0; i < strs[0].Length; i++)
            {
                for (var j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j][i] > strs[j + 1][i])
                    {
                        counter++;
                        break;
                    }
                }
            }

            return counter;
        }
    }
}