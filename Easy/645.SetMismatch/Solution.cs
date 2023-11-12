namespace Easy._645.SetMismatch;

/*
 * Beats 71.57% by speed and 53.92% by memory
 */
public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int[] numbers = new int[nums.Length];
        for (int i = 0; i < nums.Length; ++i)
        {
            ++numbers[nums[i] - 1];
        }

        int[] result = new int[2];
        for (int i = 0; i < numbers.Length; ++i)
        {
            if (numbers[i] == 0)
                result[1] = i + 1;
            if (numbers[i] == 2)
                result[0] = i + 1;
        }
        return result;
    }
}