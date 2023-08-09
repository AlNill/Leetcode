using _35.SearchInsertPosition;

var s = new Solution();

int[] nums = new int[] { 1, 3, 5, 6 };
var result = s.SearchInsert(nums, 5);
Console.WriteLine($"{result}. Expected: 2");

nums = new int[] { 1, 3, 5, 6 };
result = s.SearchInsert(nums, 2);
Console.WriteLine($"{result}. Expected: 1");

nums = new int[] { 1, 3, 5, 6 };
result = s.SearchInsert(nums, 7);
Console.WriteLine($"{result}. Expected: 4");

nums = new int[] { 1, 3, 5, 6 };
result = s.SearchInsert(nums, 0);
Console.WriteLine($"{result}. Expected: 0");

nums = new int[] { 1 };
result = s.SearchInsert(nums, 2);
Console.WriteLine($"{result}. Expected: 1");

nums = new int[] { 1 };
result = s.SearchInsert(nums, 1);
Console.WriteLine($"{result}. Expected: 0");

nums = new int[] { 1, 3 };
result = s.SearchInsert(nums, 2);
Console.WriteLine($"{result}. Expected: 1");