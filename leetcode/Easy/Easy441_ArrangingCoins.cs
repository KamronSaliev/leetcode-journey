namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/arranging-coins/
    /// </summary>
    public class Easy441_ArrangingCoins
    {
        public int ArrangeCoins(int n)
        {
            var i = 0L;
            var sum = 0L;
        
            while (sum <= n)
            {
                i++;
                sum += i;
            }

            return (int)(i - 1);
        }
    }
}