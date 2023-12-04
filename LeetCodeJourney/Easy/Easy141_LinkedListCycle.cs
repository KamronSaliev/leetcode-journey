using LeetCode.Utilities;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/linked-list-cycle/
    /// </summary>
    public class Easy141_LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast is { next: { } })
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }
    }
}