namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/calculate-money-in-leetcode-bank/
    /// </summary>
    public class Easy1716_CalculateMoneyInLeetcodeBank
    {
        public int TotalMoney(int n)
        {
            var result = 0;
            var weekRate = 0;
            var dayRate = 1;

            for (var i = 1; i <= n; i++)
            {
                result += dayRate++ + weekRate;

                if (i % 7 == 0)
                {
                    weekRate++;
                    dayRate = 1;
                }
            }

            return result;
        }
    }
}