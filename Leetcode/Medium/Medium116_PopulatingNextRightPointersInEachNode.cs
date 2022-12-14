using Leetcode.Utilities;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    /// </summary>
    public class Medium116_PopulatingNextRightPointersInEachNode
    {
        public Node Connect(Node root)
        {
            var initialRoot = root;

            while (root != null && root.left != null)
            {
                var currentRoot = root;

                while (currentRoot != null)
                {
                    currentRoot.left.next = currentRoot.right;
                    currentRoot.right.next = currentRoot.next?.left;
                    currentRoot = currentRoot.next;
                }

                root = root.left;
            }

            return initialRoot;
        }
    }
}