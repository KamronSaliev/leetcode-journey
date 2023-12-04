namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/rotate-string/
    /// </summary>
    public class Easy796_RotateString
    {
        public bool RotateString(string s, string goal)
        {
            var c = s + s;
            return c.Contains(goal) && goal.Length >= s.Length;
        }
    }
}