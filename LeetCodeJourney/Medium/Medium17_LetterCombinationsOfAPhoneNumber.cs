using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    ///     https://leetcode.com/problems/letter-combinations-of-a-phone-number/solutions/3785211/video-dial-in-your-skills-solving-letter-combinations-of-a-phone-number/
    /// </summary>
    public class Medium17_LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            var phone = new Dictionary<char, string>
            {
                { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" },
                { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" }
            };

            var result = new List<string>();

            if (digits.Length == 0)
            {
                return result;
            }

            Search("", digits, 0, phone, result);

            return result;
        }

        private void Search(string combination, string digits, int index, Dictionary<char, string> phone,
            List<string> result)
        {
            if (index == digits.Length)
            {
                result.Add(combination);
                return;
            }

            var letters = phone[digits[index]];

            foreach (var letter in letters)
            {
                Search(combination + letter, digits, index + 1, phone, result);
            }
        }
    }
}