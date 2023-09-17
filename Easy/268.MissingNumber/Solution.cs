namespace Easy._268.MissingNumber;

/*
 * Beats 94.22% by speed and 93.66% by memory
 */
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int max = 0, current = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            current += nums[i];
            max += i;
        }
        max += nums.Length;
        return max - current;
    }
}