using Easy.Common;

namespace Easy._234._Palindrome_Linked_List;

/*
 * Beats 58.43% by speed and 46.23% by memory
 */
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        var fast = head;
        var slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        var prev = slow;
        slow = slow.next;
        prev.next = null;

        while (slow != null)
        {
            var tmp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = tmp;
        }

        fast = head;
        slow = prev;
        while (slow != null)
        {
            if (fast.val != slow.val)
                return false;
            fast = fast.next;
            slow = slow.next;
        }
        return true;
    }
}
