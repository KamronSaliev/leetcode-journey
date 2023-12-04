using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/asteroid-collision/
    /// </summary>
    public class Medium735_AsteroidCollision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();

            foreach (var asteroid in asteroids)
            {
                if (asteroid > 0)
                {
                    stack.Push(asteroid);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0 || stack.Peek() < 0)
                    {
                        stack.Push(asteroid);
                    }
                    else if (stack.Peek() == Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }
                }
            }

            var result = new int[stack.Count];
            for (var i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }

            return result;
        }
    }
}