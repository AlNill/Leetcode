using Medium.Common;

namespace Medium._24.SwapNodesInPairs;


public class Solution
{
    /*
     * Beats 45.19% by speed and 96.02% by memory
     */
    public ListNode ShorterSwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        var newHead = new ListNode();
        var prev = newHead;
        var current = head;

        while(current != null && current.next != null)
        {
            prev.next = current.next;
            current.next = current.next.next;
            prev.next.next = current;

            prev = current;
            current = current.next;
        }

        return newHead.next;
    }

    /*
    * Beats 89.87% by speed and 61.13% by memory
    */
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
