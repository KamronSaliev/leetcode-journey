using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/text-justification/
    ///     https://leetcode.com/problems/text-justification/solutions/3952119/94-14-2-approaches-greedy/
    /// </summary>
    public class Hard68_TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();
            var current = new List<string>();

            var numOfLetters = 0;

            foreach (var word in words)
            {
                if (word.Length + current.Count + numOfLetters > maxWidth)
                {
                    for (var i = 0; i < maxWidth - numOfLetters; i++)
                    {
                        current[i % (current.Count - 1 > 0 ? current.Count - 1 : 1)] += " ";
                    }

                    result.Add(string.Join("", current));
                    current.Clear();
                    numOfLetters = 0;
                }

                current.Add(word);
                numOfLetters += word.Length;
            }

            var lastLine = string.Join(" ", current);

            while (lastLine.Length < maxWidth)
            {
                lastLine += " ";
            }

            result.Add(lastLine);

            return result;
        }
    }
}