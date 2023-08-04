#nullable disable
namespace _21.MergeTwoSortedLists;

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null || list2 == null)
            return list1 == null ? list2 : list1;
        
        if (list1.val <= list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        
        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }
}
