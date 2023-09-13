namespace Easy._219.ContainsDuplicateII;

/*
 * Beats 77.98% by speed and Beats 86.16% by memory
 */
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> hashTable = new HashSet<int>();
        int left = 0;
        for (int right = 0; right < nums.Length; ++right)
        {
            if (right - left > k)
            {
                hashTable.Remove(nums[left]);
                ++left;
            }
            if (hashTable.Contains(nums[right]))
                return true;
            hashTable.Add(nums[right]);
        }
        return false;
    }
}
