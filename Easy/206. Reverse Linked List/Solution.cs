using Easy.Common;

namespace Easy._206._Reverse_Linked_List;

/*
 * Beats 97.30% by speed and Beats 84.99% by memory
 */
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        ListNode prev = null;
        while (head != null)
        {
            var current = head;
            head = head.next;
            current.next = prev;
            prev = current;
        }
        return prev;
    }
}
