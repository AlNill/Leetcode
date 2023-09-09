namespace Easy._27.RemoveElement;

/*
 * As result code via recursion beats 90.23% by runtime and 85.80% by memory 
 * and via create new ListNode beats 92.28% by speed and 29.43% by memory.
 */
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;

        int startIndex = 0, endIndex = 0;
        bool isContain = false;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == val)
            {
                isContain = true;
                startIndex = i;
                int counter = 1;
                while (i < nums.Length && nums[i] == val)
                {
                    nums[i] = nums[nums.Length - counter];
                    ++counter;
                    endIndex = i++;
                }
            }
        }

        return isContain ? nums.Length - (endIndex - startIndex + 1) : nums.Length;
    }

    // O(n) Solution
    public int PrettyRemoveElement(int[] nums, int val)
    {
        int i = 0;
        foreach (int n in nums)
        {
            if (n != val)
                nums[i++] = n;
        }
        return i;
    }
}
