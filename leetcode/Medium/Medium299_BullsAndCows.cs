using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/bulls-and-cows/
    /// </summary>
    public class Medium299_BullsAndCows
    {
        public string GetHint(string secret, string guess)
        {
            var cows = 0;
            var bulls = 0;
            var counter = 0;

            var dict = new Dictionary<char, int>();
            var dict2 = new Dictionary<char, int>();

            for (var i = 0; i < secret.Length; i++)
            {
                if (dict.ContainsKey(secret[i]))
                {
                    dict[secret[i]]++;
                }
                else
                {
                    dict.Add(secret[i], 1);
                }

                if (secret[i] == guess[counter])
                {
                    bulls++;
                }

                counter++;
            }

            for (var i = 0; i < guess.Length; i++)
            {
                if (dict2.ContainsKey(guess[i]))
                {
                    dict2[guess[i]]++;
                }
                else
                {
                    dict2.Add(guess[i], 1);
                }

                if (dict.ContainsKey(guess[i]) && dict[guess[i]] > 0 && dict2[guess[i]] > 0)
                {
                    cows++;
                    
                    dict2[guess[i]]--;
                    dict[guess[i]]--;
                }
            }

            cows -= bulls;

            return $"{bulls}A{cows}B";
        }
    }
}