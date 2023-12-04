using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/partition-list/
    /// </summary>
    public class Medium86_PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            var before = new ListNode();
            var after = new ListNode();
            var beforeCurrent = before;
            var afterCurrent = after;

            while (head != null)
            {
                if (head.val < x)
                {
                    beforeCurrent.next = head;
                    beforeCurrent = beforeCurrent.next;
                }
                else
                {
                    afterCurrent.next = head;
                    afterCurrent = afterCurrent.next;
                }

                head = head.next;
            }

            afterCurrent.next = null;
            beforeCurrent.next = after.next;

            return before.next;
        }
    }
}