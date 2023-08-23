using _88.MergeSortedArray;

var s = new Solution();
int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 }; 
int[] nums2 = new int[3] { 2, 5, 6 };
s.Merge(nums1, 3, nums2, 3);
Console.WriteLine(nums1);
