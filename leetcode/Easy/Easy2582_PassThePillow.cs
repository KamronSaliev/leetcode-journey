namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/pass-the-pillow/
    /// </summary>
    public class Easy2582_PassThePillow
    {
        public int PassThePillow(int n, int time)
        {
            n--;

            var quotient = time / n;
            var remainder = time % n;

            if (quotient % 2 == 0)
            {
                return remainder + 1;
            }

            return n - remainder + 1;
        }
    }
}