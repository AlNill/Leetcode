namespace _141.LinkedListCycle;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode current = head;
        ListNode next = head;

        while (next != null && next.next != null)
        {
            current = current.next;
            next = next.next.next;

            if (next == current)
                return true;
        }
        return false;
    }
}
