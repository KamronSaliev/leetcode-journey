namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-vowels-of-a-string/
    /// </summary>
    public class Easy345_ReverseVowelsOfAString
    {
        public string ReverseVowels(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            var chars = s.ToCharArray();

            while (left < right)
            {
                var isLeftVowel = IsVowel(s[left]);
                var isRightVowel = IsVowel(s[right]);

                if (isLeftVowel && isRightVowel)
                {
                    Swap(chars, left, right);
                    left++;
                    right--;
                }
                else if (isLeftVowel)
                {
                    right--;
                }
                else if (isRightVowel)
                {
                    left++;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return new string(chars);
        }

        private void Swap(char[] s, int left, int right)
        {
            (s[left], s[right]) = (s[right], s[left]);
        }

        private bool IsVowel(char c)
        {
            return c is 'a' or 'e' or 'i' or 'o' or 'u' or 'A' or 'E' or 'I' or 'O' or 'U';
        }
    }
}