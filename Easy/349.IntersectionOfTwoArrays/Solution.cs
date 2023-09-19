namespace Easy._349.IntersectionOfTwoArrays;

/*
 * Beats 93.19% by speed and 84.33% by memory
 */
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> result = new HashSet<int>();
        for (int i = 0; i < nums1.Length; ++i)
        {
            if (nums2.Contains(nums1[i]))
                result.Add(nums1[i]);
        }
        return result.ToArray();
    }
}
