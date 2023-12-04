using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Easy
{
    public class Easy637_AverageOfLevelsInBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var result = new List<double>();

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var sum = 0d;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    sum += current.val;

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                sum /= size;
                result.Add(sum);
            }

            return result;
        }
    }
}