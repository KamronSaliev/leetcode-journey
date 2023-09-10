namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/count-all-valid-pickup-and-delivery-options/
    /// </summary>
    public class Hard1359_CountAllValidPickupAndDeliveryOptions
    {
        public int CountOrders(int n)
        {
            const int mod = (int)1e9 + 7;
            var count = 1L;

            for (var i = 2; i <= n; i++)
            {
                count = count * (2 * i - 1) * i % mod;
            }

            return (int)count;
        }
    }
}