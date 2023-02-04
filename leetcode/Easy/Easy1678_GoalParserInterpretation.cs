namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/goal-parser-interpretation/
    /// </summary>
    public class Easy1678_GoalParserInterpretation
    {
        public string Interpret(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }
}