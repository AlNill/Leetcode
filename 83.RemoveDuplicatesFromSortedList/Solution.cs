namespace _83.RemoveDuplicatesFromSortedList;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

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
