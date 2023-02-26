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
            if (Check(head, root))
            {
                return true;
            }

            if (head == null)
            {
                return true;
            }

            if (root == null)
            {
                return false;
            }
            
            return IsSubPath(head, root.left) || IsSubPath(head, root.right);
        }

        private bool Check(ListNode head, TreeNode root)
        {
            if (head == null)
            {
                return true;
            }

            if (root == null)
            {
                return false;
            }

            if (head.val == root.val)
            {
                return IsSubPath(head.next, root.left) || IsSubPath(head.next, root.right);
            }

            return false;
        }
    }
}