namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/check-if-it-is-a-straight-line/
    /// </summary>
    public class Easy1232_CheckIfItIsAStraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            var x1 = coordinates[0][0];
            var y1 = coordinates[0][1];
            var x2 = coordinates[1][0];
            var y2 = coordinates[1][1];

            for (var i = 2; i < coordinates.Length; i++)
            {
                var x = coordinates[i][0];
                var y = coordinates[i][1];

                if ((y - y1) * (x2 - x1) != (y2 - y1) * (x - x1))
                {
                    return false;
                }
            }

            return true;
        }
    }
}