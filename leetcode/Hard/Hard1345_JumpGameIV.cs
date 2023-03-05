using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/jump-game-iv/
    /// </summary>
    public class Hard1345_JumpGameIV
    {
        public int MinJumps(int[] arr)
        {
            var graph = new Dictionary<int, List<int>>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (graph.ContainsKey(arr[i]))
                {
                    graph[arr[i]].Add(i);
                }
                else
                {
                    graph.Add(arr[i], new List<int> { i });
                }
            }

            var step = 0;

            var visited = new bool[arr.Length];
            visited[0] = true;

            var queue = new Queue<int>();
            queue.Enqueue(0);
            while (queue.Count > 0)
            {
                var size = queue.Count;

                while (size-- > 0)
                {
                    var current = queue.Dequeue();
                    if (current == arr.Length - 1)
                    {
                        return step;
                    }

                    var nextSteps = graph[arr[current]];
                    nextSteps.Add(current - 1);
                    nextSteps.Add(current + 1);

                    foreach (var nextStep in nextSteps)
                    {
                        if (nextStep >= 0 && nextStep < arr.Length && !visited[nextStep])
                        {
                            visited[nextStep] = true;
                            queue.Enqueue(nextStep);
                        }
                    }

                    nextSteps.Clear();
                }

                step++;
            }

            return 0;
        }
    }
}