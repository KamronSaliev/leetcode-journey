using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/build-an-array-with-stack-operations/
    /// </summary>
    public class Medium1441_BuildAnArrayWithStackOperations
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            const string pushActionString = "Push";
            const string popActionString = "Pop";

            var targetSet = new HashSet<int>(target);
            var result = new List<string>();

            for (var i = 1; i <= target[^1]; i++)
            {
                if (targetSet.Contains(i))
                {
                    result.Add(pushActionString);
                }
                else
                {
                    result.Add(pushActionString);
                    result.Add(popActionString);
                }
            }

            return result;
        }
    }
}