using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/fizz-buzz/
    /// </summary>
    public class Easy412_FizzBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            var result = new List<string>();

            for (var i = 1; i <= n; i++)
            {
                var temp = (i % 3 == 0, i % 5 == 0) switch
                {
                    (true, true) => "FizzBuzz",
                    (true, false) => "Fizz",
                    (false, true) => "Buzz",
                    (false, false) => i.ToString()
                };

                result.Add(temp);
            }

            return result;
        }
    }
}