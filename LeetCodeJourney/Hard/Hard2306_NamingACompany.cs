using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/naming-a-company/
    /// </summary>
    public class Hard2306_NamingACompany
    {
        public long DistinctNames(string[] ideas)
        {
            var nameGroups = new HashSet<string>[26];
            var result = 0L;

            for (var i = 0; i < 26; i++)
            {
                nameGroups[i] = new HashSet<string>();
            }

            foreach (var idea in ideas)
            {
                nameGroups[idea[0] - 'a'].Add(idea[1..]);
            }

            for (var i = 0; i < 25; i++)
            {
                for (var j = i + 1; j < 26; j++)
                {
                    var mutualCount = nameGroups[i].Count(idea => nameGroups[j].Contains(idea));
                    result += 2 * (nameGroups[i].Count - mutualCount) * (nameGroups[j].Count - mutualCount);
                }
            }

            return result;
        }
    }
}