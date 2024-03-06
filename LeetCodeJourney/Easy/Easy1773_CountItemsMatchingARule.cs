using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/count-items-matching-a-rule/
    /// </summary>
    public class Easy1773_CountItemsMatchingARule
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var ruleKeyIndex = 0;

            ruleKeyIndex = ruleKey switch
            {
                "color" => 1,
                "name" => 2,
                _ => ruleKeyIndex
            };

            return items.Count(list => list[ruleKeyIndex] == ruleValue);
        }
    }
}