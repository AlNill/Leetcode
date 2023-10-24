using Medium.Common;

namespace Medium._19.RemoveNthNodeFromEndOfList;

/*
 * Beats 96.78% by speed and 23.36% by memory
 */
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode newHead = new ListNode();
        newHead.next = head;
        ListNode slow = newHead, fast = newHead;
        for (int i = 0; i < n + 1; ++i)
        {
            fast = fast.next;
        }

        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;
        return newHead.next;
    }
}
