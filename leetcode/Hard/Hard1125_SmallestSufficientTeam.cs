using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/smallest-sufficient-team/
    ///     https://leetcode.com/problems/smallest-sufficient-team/solutions/3771015/c-a-simple-guide-to-solving-this-problem-with-clean-code/
    /// </summary>
    public class Hard1125_SmallestSufficientTeam
    {
        public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people)
        {
            var bitMaskKey = BuildBitMask(req_skills);
            var skillSets = new Dictionary<int, List<int>>
            {
                [0] = new()
            };

            for (var i = 0; i < people.Count; ++i)
            {
                var bitmask = ConvertPersonToBitMask(bitMaskKey, people[i]);
                foreach (var key in skillSets.Keys.ToArray())
                {
                    if ((key & bitmask) != bitmask)
                    {
                        var newBitmask = key | bitmask;

                        if (!skillSets.ContainsKey(newBitmask) ||
                            skillSets[newBitmask].Count > skillSets[key].Count + 1)
                        {
                            skillSets[newBitmask] = new List<int>(skillSets[key]) { i };
                        }
                    }
                }
            }

            return skillSets[ConvertPersonToBitMask(bitMaskKey, req_skills)].ToArray();
        }

        private Dictionary<string, int> BuildBitMask(string[] req_skills)
        {
            var bitMaskKey = new Dictionary<string, int>();
            var val = 1;
            
            foreach (var skill in req_skills)
            {
                bitMaskKey.Add(skill, val);
                val *= 2;
            }

            return bitMaskKey;
        }

        private int ConvertPersonToBitMask(Dictionary<string, int> bitMaskKey, IEnumerable<string> person)
        {
            var bitmask = 0;
            
            foreach (var skill in person)
            {
                bitmask += bitMaskKey[skill];
            }

            return bitmask;
        }
    }
}