#nullable disable
using Easy.Common;
namespace Easy._83.RemoveDuplicatesFromSortedList;

/*
 * As result code beats 93.04% by runtime and 74.20% by memory.
 */
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;
        var tmp = head;
        while (tmp.next != null)
        {
            int current = tmp.val;
            if (tmp.next.val == current)
            {
                tmp.next = tmp.next.next;
            }
            else
            {
                tmp = tmp.next;
            }
        }
        return head;
    }
}
