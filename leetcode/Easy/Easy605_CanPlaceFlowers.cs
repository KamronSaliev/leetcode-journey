namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/can-place-flowers/
    /// </summary>
    public class Easy605_CanPlaceFlowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var count = 0;
            
            for (var i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] != 0 || (i != 0 && flowerbed[i - 1] != 0) ||
                    (i != flowerbed.Length - 1 && flowerbed[i + 1] != 0))
                {
                    continue;
                }

                flowerbed[i] = 1;
                count++;
            }

            return count >= n;
        }
    }
}