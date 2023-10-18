namespace Easy._350.IntersectionOfTwoArraysII;

public class Solution
{
    /*
     * Beats 96.1% by speed and 43.93% by memory
     */
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            return Intersect(nums2, nums1);
        Dictionary<int, int> counter = new Dictionary<int, int>();
        List<int> result = new List<int>();
        for (int i = 0; i < nums1.Length; ++i)
        {
            if (!counter.ContainsKey(nums1[i]))
                counter.Add(nums1[i], 0);
            ++counter[nums1[i]];
        }

        for (int i = 0; i < nums2.Length; ++i)
        {
            if (!counter.ContainsKey(nums2[i]))
                continue;
            if (counter[nums2[i]] <= 0)
                continue;

            --counter[nums2[i]];
            result.Add(nums2[i]);
        }

        return result.ToArray();
    }


    /*
     * Beats 82.53% by speed and 88.52% by memory
     */
    public int[] IntersectWithSorting(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);

        int i = 0, j = 0;
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
                ++i;
            else if (nums2[j] < nums1[i])
                ++j;
            else
            {
                result.Add(nums1[i]);
                ++i;
                ++j;
            }
        }
        return result.ToArray();
    }
}