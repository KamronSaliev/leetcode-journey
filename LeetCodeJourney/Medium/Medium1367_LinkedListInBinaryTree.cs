using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/linked-list-in-binary-tree/
    /// </summary>
    public class Medium1367_LinkedListInBinaryTree
    {
        public bool IsSubPath(ListNode head, TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            if (DFS(head, root))
            {
                return true;
            }
            
            return IsSubPath(head, root.left) || IsSubPath(head, root.right);
        }

        private bool DFS(ListNode head, TreeNode root)
        {
            if (head == null)
            {
                return true;
            }

            if (root == null)
            {
                return false;
            }

            return head.val == root.val && (DFS(head.next, root.left) || DFS(head.next, root.right));
        }
    }
}