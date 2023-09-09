using Easy.Common;
namespace Easy._160.IntersectionOfTwoLinkedLists;

/*
 * As result code beats 99.71% by runtime and 70.20% by memory.
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var nodeA = headA;
        var nodeB = headB;
        while (nodeA != nodeB)
        {
            nodeA = nodeA != null ? nodeA.next : headB;
            nodeB = nodeB != null ? nodeB.next : headA;
        }
        return nodeA;
    }
}

