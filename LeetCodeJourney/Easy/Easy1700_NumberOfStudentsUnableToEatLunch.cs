using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/
    /// </summary>
    public class Easy1700_NumberOfStudentsUnableToEatLunch
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            var stack = new Stack<int>(sandwiches.Reverse());
            var queue = new Queue<int>(students);
            var result = 0;

            while (result < queue.Count)
            {
                if (stack.Peek() == queue.Peek())
                {
                    stack.Pop();
                    queue.Dequeue();
                    result = 0;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                    result++;
                }
            }

            return result;
        }
    }
}