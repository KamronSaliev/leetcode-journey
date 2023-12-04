namespace LeetCode.Medium
{
    /// <summary>
    ///     /https://leetcode.com/problems/find-the-winner-of-an-array-game/
    /// </summary>
    public class Medium1535_FindTheWinnerOfAnArrayGame
    {
        public int GetWinner(int[] arr, int k)
        {
            var currentWinner = arr[0];
            var consecutiveWinsCount = 0;

            for (var i = 1; i < arr.Length; i++)
            {
                if (currentWinner > arr[i])
                {
                    consecutiveWinsCount++;
                }
                else
                {
                    currentWinner = arr[i];
                    consecutiveWinsCount = 1;
                }

                if (consecutiveWinsCount == k)
                {
                    return currentWinner;
                }
            }

            return currentWinner;
        }
    }
}