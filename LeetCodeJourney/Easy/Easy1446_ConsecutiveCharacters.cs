namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/consecutive-characters/
    /// </summary>
    public class Easy1446_ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {
            var counter = 1;
            var maxPower = counter;

            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    counter++;
                    continue;
                }

                if (counter > maxPower)
                {
                    maxPower = counter;
                }

                counter = 1;
            }

            if (counter > maxPower)
            {
                maxPower = counter;
            }

            return maxPower;
        }
    }
}