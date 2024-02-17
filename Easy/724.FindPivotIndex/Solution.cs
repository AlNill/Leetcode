namespace Easy._724.FindPivotIndex;

/*
 * Beats 81.52% by speed and 68.29% by memory
 */
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int leftSum = 0, totalSum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            totalSum += nums[i];
        }

        for (int i = 0; i < nums.Length; ++i)
        {
            if (leftSum * 2 == totalSum - nums[i])
                return i;
            leftSum += nums[i];
        }
        return -1;
    }
}