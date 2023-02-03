namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-words-in-a-string-iii/
    /// </summary>
    public class Easy557_ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            var arr = s.ToCharArray();
            var start = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ' && i != arr.Length - 1)
                {
                    continue;
                }

                if (arr[start] == ' ')
                {
                    start++;
                }

                if (i == arr.Length - 1)
                {
                    i++;
                }

                Reverse(start, i - 1, arr);
                start = i;
            }

            return new string(arr);
        }

        private void Reverse(int l, int r, char[] s)
        {
            while (l < r)
            {
                (s[l], s[r]) = (s[r], s[l]);

                r--;
                l++;
            }
        }
    }
}