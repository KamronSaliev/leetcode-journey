namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-flips-to-make-a-or-b-equal-to-c/
    /// </summary>
    public class Medium1318_MinimumFlipsToMakeAORBEqualToC
    {
        public int MinFlips(int a, int b, int c)
        {
            var flips = 0;

            for (var i = 0; i < 32; i++)
            {
                var mask = 1 << i;
                var aBit = a & mask;
                var bBit = b & mask;
                var cBit = c & mask;

                if (cBit == 0)
                {
                    if (aBit > 0 && bBit > 0)
                    {
                        flips += 2;
                    }

                    else if (aBit > 0 || bBit > 0)
                    {
                        flips++;
                    }
                }
                else
                {
                    if (aBit == 0 && bBit == 0)
                    {
                        flips++;
                    }
                }
            }

            return flips;
        }
    }
}