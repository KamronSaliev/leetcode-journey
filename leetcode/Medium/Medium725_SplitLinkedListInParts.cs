using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/split-linked-list-in-parts/
    /// </summary>
    public class Medium725_SplitLinkedListInParts
    {
        public ListNode[] SplitListToParts(ListNode head, int k)
        {
            var count = 0;
            var current = head;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            var partSize = count / k;
            var extraNodesSize = count % k;

            var result = new ListNode[k];
            current = head;

            for (var i = 0; i < k; i++)
            {
                result[i] = current;
                var currentPartSize = partSize + (extraNodesSize > 0 ? 1 : 0);

                for (var j = 0; j < currentPartSize - 1; j++)
                {
                    current = current?.next;
                }

                if (extraNodesSize > 0)
                {
                    extraNodesSize--;
                }

                if (current == null)
                {
                    continue;
                }

                var temp = current.next;
                current.next = null;
                current = temp;
            }

            return result;
        }
    }
}