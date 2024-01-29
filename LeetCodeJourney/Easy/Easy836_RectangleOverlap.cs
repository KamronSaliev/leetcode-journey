namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/rectangle-overlap/
    /// </summary>
    public class Easy836_RectangleOverlap
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return rec2[0] < rec1[2] && rec1[0] < rec2[2] && rec2[1] < rec1[3] && rec1[1] < rec2[3];
        }
    }
}