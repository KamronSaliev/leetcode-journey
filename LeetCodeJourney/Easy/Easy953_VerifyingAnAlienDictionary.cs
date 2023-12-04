using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/verifying-an-alien-dictionary/
    /// </summary>
    public class Easy953_VerifyingAnAlienDictionary
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var orderDictionary = new Dictionary<char, int>();

            for (var i = 0; i < order.Length; i++)
            {
                orderDictionary[order[i]] = i;
            }

            for (var i = 0; i < words.Length - 1; i++)
            {
                for (var j = 0; j < words[i].Length; j++)
                {
                    if (j >= words[i + 1].Length)
                    {
                        return false;
                    }

                    var currentWordChar = words[i][j];
                    var nextWordChar = words[i + 1][j];

                    if (orderDictionary[currentWordChar] > orderDictionary[nextWordChar])
                    {
                        return false;
                    }

                    if (orderDictionary[currentWordChar] < orderDictionary[nextWordChar])
                    {
                        break;
                    }
                }
            }

            return true;
        }
    }
}