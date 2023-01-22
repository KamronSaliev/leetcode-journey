using System.Linq;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/plus-one/
    /// </summary>
    public class Easy66_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            var digitsList = digits.ToList();

            for (var i = digitsList.Count - 1; i >= 0; i--)
            {
                if (digitsList[i] == 9)
                {
                    digitsList[i] = 0;
                }
                else
                {
                    digitsList[i] += 1;
                    return digitsList.ToArray();
                }
            }

            digitsList.Insert(0, 1);
            return digitsList.ToArray();
        }
    }
}