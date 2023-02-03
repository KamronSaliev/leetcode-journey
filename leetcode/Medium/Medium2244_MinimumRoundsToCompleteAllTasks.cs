using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-rounds-to-complete-all-tasks/
    /// </summary>
    public class Medium2244_MinimumRoundsToCompleteAllTasks
    {
        public int MinimumRounds(int[] tasks)
        {
            var groupedTasks = tasks.GroupBy(i => i);
            var ans = 0;

            foreach (var groupedTask in groupedTasks)
            {
                var taskCount = groupedTask.Count();

                if (taskCount < 2)
                {
                    return -1;
                }

                if (taskCount % 3 == 0)
                {
                    ans += taskCount / 3;
                }
                else
                {
                    ans += taskCount / 3 + 1;
                }
            }

            return ans;
        }
    }
}