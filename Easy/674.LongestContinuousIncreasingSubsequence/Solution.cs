namespace Easy._674.LongestContinuousIncreasingSubsequence;

/*
 * Beats 90.58% by speed and 34.78% by memory
 */
public class Solution
{
    public int FindLengthOfLCIS(int[] nums)
    {
        if (nums.Length == 1)
            return 1;
        int left = 0, right = 0, maxLen = 0;
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] > nums[i - 1])
                right = i;
            else
            {
                maxLen = right - left > maxLen ? right - left : maxLen;
                left = i;
                right = i;
            }
        }
        maxLen = right - left > maxLen ? right - left : maxLen;
        return maxLen + 1;
    }
}