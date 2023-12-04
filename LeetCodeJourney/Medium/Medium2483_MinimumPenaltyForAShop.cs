namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-penalty-for-a-shop/
    /// </summary>
    public class Medium2483_MinimumPenaltyForAShop
    {
        public int BestClosingTime(string customers)
        {
            var currentScore = 0;
            var maxScore = 0;
            var hour = -1;

            for (var i = 0; i < customers.Length; i++)
            {
                if (customers[i] == 'Y')
                {
                    currentScore++;
                }
                else
                {
                    currentScore--;
                }

                if (currentScore <= maxScore)
                {
                    continue;
                }

                maxScore = currentScore;
                hour = i;
            }

            return hour + 1;
        }
    }
}