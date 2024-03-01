namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-odd-binary-number/
    /// </summary>
    public class Easy2864_MaximumOddBinaryNumber
    {
        public string MaximumOddBinaryNumber(string s)
        {
            var numberOfOnes = 0;
            var numberOfZeros = 0;

            foreach (var c in s)
            {
                if (c == '1')
                {
                    numberOfOnes++;
                }
                else
                {
                    numberOfZeros++;
                }
            }

            if (numberOfZeros == 0)
            {
                return s;
            }

            return new string('1', numberOfOnes - 1) + new string('0', numberOfZeros) + "1";
        }
    }
}