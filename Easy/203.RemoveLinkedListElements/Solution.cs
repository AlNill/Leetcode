using Easy.Common;

namespace Easy._203.RemoveLinkedListElements;

/*
 * Beats 85.76% by speed and Beats 47.22% by memory
 */
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        while (head != null && head.val == val)
        {
            head = head.next;
        }

        var tmp = head;
        while (tmp != null && tmp.next != null)
        {
            if (tmp.next.val == val)
            {
                var tmp2 = tmp.next;
                while (tmp2 != null && tmp2.val == val)
                {
                    tmp2 = tmp2.next;
                }

                tmp.next = tmp2;
            }
            tmp = tmp.next;
        }
        return head;
    }
}