namespace _21.MergeTwoSortedLists;

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode result;

        if (list1 == null && list2 == null)
            return null;

        if (list1 == null && list2 != null)
            return list2;

        if (list2 == null && list1 != null)
            return list1;

        if (list1.val <= list2.val)
        {
            result = new ListNode(val: list1.val);
            list1 = list1.next;
        }
        else
        {
            result = new ListNode(val: list2.val);
            list2 = list2.next;
        }

        ListNode head = result;

        while (list1 != null)
        {
            if (list2 == null)
                break;
            while (list2.val <= list1.val)
            {
                result.next = new ListNode(val: list2.val);
                list2 = list2.next;
                result = result.next;
                if (list2 == null)
                {
                    break;
                }
            }
            
            result.next = new ListNode(val: list1.val);
            result = result.next;
            list1 = list1.next;
        }

        if (list1 == null && list2 != null)
        {
            while (list2 != null)
            {
                result.next = new ListNode(val: list2.val);
                list2 = list2.next;
                result = result.next;
            }
        }

        if (list2 == null && list1 != null)
        {
            while (list1 != null)
            {
                result.next = new ListNode(val: list1.val);
                list1 = list1.next;
                result = result.next;
            }
        }

        return head;
    }
}
