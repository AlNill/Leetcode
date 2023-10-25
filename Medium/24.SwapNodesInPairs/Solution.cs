using Medium.Common;

namespace Medium._24.SwapNodesInPairs;

/*
 * Beats 89.87% by speed and 61.13% by memory
 */
public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        var start = head;
        var next = head.next;
        var newHead = next;

        ListNode prevStart = null;
        while (next != null)
        {
            start.next = next.next;
            next.next = start;
            if (prevStart != null)
                prevStart.next = next;

            if (next.next.next == null || next.next.next.next == null)
                break;

            prevStart = start;
            next = next.next.next.next;
            start = start.next;
        }
        return newHead;
    }
}
