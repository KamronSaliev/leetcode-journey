namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/lemonade-change/
    /// </summary>
    public class Easy860_LemonadeChange
    {
        public bool LemonadeChange(int[] bills)
        {
            var five = 0;
            var ten = 0;

            for (var i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    five++;
                }
                else if (bills[i] == 10)
                {
                    five--;
                    ten++;
                }
                else if (ten > 0)
                {
                    five--;
                    ten--;
                }
                else
                {
                    five -= 3;
                }

                if (five < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}