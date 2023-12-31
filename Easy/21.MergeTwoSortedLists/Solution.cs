﻿#nullable disable
using Easy.Common;
namespace Easy._21.MergeTwoSortedLists;

/*
 * As result code via recursion beats 90.23% by runtime and 85.80% by memory and via create new ListNode beats 92.28% by speed and 29.43% by memory.
 */
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

    public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
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
