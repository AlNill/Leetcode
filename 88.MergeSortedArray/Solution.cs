namespace _88.MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int lastIndex = m + n - 1, nums1Index = m - 1, nums2Index = n - 1;
        while(nums1Index >= 0 && nums2Index >= 0)
        {
            if (nums1[nums1Index] >= nums2[nums2Index])
            {
                nums1[lastIndex] = nums1[nums1Index];
                --nums1Index;
                --lastIndex;
            }
            else
            {
                nums1[lastIndex] = nums2[nums2Index];
                --nums2Index;
                --lastIndex;
            }
        }

        while(nums2Index >= 0)
        {
            nums1[lastIndex] = nums2[nums2Index];
            --nums2Index;
            --lastIndex;
        }
    }
}
