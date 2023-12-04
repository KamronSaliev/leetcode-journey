namespace LeetCode.Medium
{
    public class Medium2187_MinimumTimeToCompleteTrips
    {
        public long MinimumTime(int[] time, int totalTrips)
        {
            var left = 0L;
            
            // calculated by multiplying maximum values of time and totalTrips
            var right = (long)1e14;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var sum = 0L;
                
                for (var i = 0; i < time.Length; i++)
                {
                    sum += mid / time[i];
                }

                if (sum < totalTrips)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
}