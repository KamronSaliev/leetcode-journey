using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/letter-case-permutation/
    /// </summary>
    public class Medium784_LetterCasePermutation
    {
        public IList<string> LetterCasePermutation(string s)
        {
            var ans = new List<string>();
            var sb = new StringBuilder();

            Backtrack(s, 0, sb, ans);

            return ans;
        }

        private void Backtrack(string s, int index, StringBuilder sb, IList<string> ans)
        {
            if (sb.Length == s.Length)
            {
                ans.Add(sb.ToString());
                return;
            }

            for (var i = index; i < s.Length; i++)
            {
                sb.Append(s[i]);
                Backtrack(s, i + 1, sb, ans);
                sb.Remove(sb.Length - 1, 1);

                if (char.IsLetter(s[i]))
                {
                    sb.Append(char.IsLower(s[i]) ? char.ToUpper(s[i]) : char.ToLower(s[i]));
                    Backtrack(s, i + 1, sb, ans);
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }
    }
}