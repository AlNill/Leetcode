using Medium.Common;

namespace Medium._2.AddTwoNumbers;


/*
 * Beats 85.36% by speed and Beats 98.71% by memory
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int isExt = 0;
        var head = l1;
        while (l1.next != null && l2.next != null)
        {
            int sum = l1.val + l2.val + isExt;
            isExt = 0;
            int digit = sum % 10;
            isExt = sum / 10 == 0 ? 0 : 1;
            l1.val = digit;
            l1 = l1.next;
            l2 = l2.next;
        }

        if (l1.next == null && l2.next != null)
        {
            int sum = l1.val + l2.val + isExt;
            isExt = 0;
            int digit = sum % 10;
            isExt = sum / 10 == 0 ? 0 : 1;
            l1.val = digit;
            l2 = l2.next;

            while (l2 != null)
            {
                sum = l2.val + isExt;
                isExt = 0;
                digit = sum % 10;
                isExt = sum / 10 == 0 ? 0 : 1;
                l1.next = new ListNode(val: digit);
                l1 = l1.next;
                l2 = l2.next;
            }

            if (isExt == 1)
                l1.next = new ListNode(val: 1);
            return head;
        }

        if (l2.next == null && l1.next != null)
        {
            int sum = l1.val + l2.val + isExt;
            isExt = 0;
            int digit = sum % 10;
            isExt = sum / 10 == 0 ? 0 : 1;
            l1.val = digit;
            l1 = l1.next;

            while (l1.next != null)
            {
                sum = l1.val + isExt;
                isExt = 0;
                digit = sum % 10;
                isExt = sum / 10 == 0 ? 0 : 1;
                l1.val = digit;
                l1 = l1.next;
            }

            if (isExt == 1)
            {
                sum = l1.val + isExt;
                isExt = 0;
                digit = sum % 10;
                isExt = sum / 10 == 0 ? 0 : 1;
                l1.val = digit;
                if (isExt == 1)
                    l1.next = new ListNode(val: 1); ;
            }

            return head;
        }

        int sum2 = l1.val + l2.val + isExt;
        isExt = 0;
        int digit2 = sum2 % 10;
        isExt = sum2 / 10 == 0 ? 0 : 1;
        l1.val = digit2;

        if (isExt == 1)
            l1.next = new ListNode(val: 1);
        return head;
    }
}
