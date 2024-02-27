namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/
    /// </summary>
    public class Easy1450_NumberOfStudentsDoingHomeworkAtAGivenTime
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            var result = 0;
            
            for (var i = 0; i < startTime.Length; i++)
            {
                result += queryTime >= startTime[i] && queryTime <= endTime[i] ? 1 : 0;
            }

            return result;
        }
    }
}