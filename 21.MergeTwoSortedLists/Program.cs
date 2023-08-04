using _21.MergeTwoSortedLists;

void ManualTest1()
{
    Console.WriteLine("Manual test1: [1, 2, 4], [1, 3, 4]");
    ListNode list1 = new ListNode(val: 1);
    ListNode headOfList1 = list1;

    ListNode list2 = new ListNode(val: 1);
    ListNode headOfList2 = list2;

    list1.val = 1;
    list1.next = new ListNode(val: 2);
    list1 = list1.next;
    list1.next = new ListNode(val: 4);
    list1 = list1.next;

    list2.val = 1;
    list2.next = new ListNode(val: 3);
    list2 = list2.next;
    list2.next = new ListNode(val: 4);
    list2 = list2.next;

    var solution = new Solution();
    var result = solution.MergeTwoLists(headOfList1, headOfList2);

    Console.WriteLine("Manual test1 done:");
    while (result != null)
    {
        Console.WriteLine(result.val);
        result = result.next;
    }
}

ManualTest1();


