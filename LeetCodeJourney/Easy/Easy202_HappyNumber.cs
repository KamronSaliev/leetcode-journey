namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/happy-number/
    /// </summary>
    public class Easy202_HappyNumber
    {
        public bool IsHappy(int n)
        {
            var slow = n;
            var fast = n;

            do
            {
                fast = GetNext(fast);
                fast = GetNext(fast);
                slow = GetNext(slow);
            } while (fast != slow);

            return fast == 1;
        }

        private int GetNext(int n)
        {
            var sum = 0;

            while (n != 0)
            {
                var temp = n % 10;
                sum += temp * temp;
                n /= 10;
            }

            return sum;
        }
    }
}