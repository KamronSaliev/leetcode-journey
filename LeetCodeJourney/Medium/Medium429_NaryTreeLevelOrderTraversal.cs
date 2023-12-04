using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/n-ary-tree-level-order-traversal/
    /// </summary>
    public class Medium429_NaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();
            
            if (root == null)
            {
                return result;
            }
            
            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var levelNodes = new List<int>();

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    
                    levelNodes.Add(current.val);

                    for (var j = 0; j < current.children.Count; j++)
                    {
                        queue.Enqueue(current.children[j]);
                    }
                }
                
                result.Add(levelNodes);
            }

            return result;
        }
    }
}