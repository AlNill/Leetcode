using _27.RemoveElement;

var s = new Solution();
int[] test = new int[] { 3, 2, 2, 3 };
int k = s.RemoveElement(test, 3);
Console.WriteLine($"Expected: 2. Out: {k}");

test = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
k = s.RemoveElement(test, 2);
Console.WriteLine($"Expected: 5. Out: {k}");

test = new int[] { 2 };
k = s.RemoveElement(test, 3);
Console.WriteLine($"Expected: 1. Out: {k}");