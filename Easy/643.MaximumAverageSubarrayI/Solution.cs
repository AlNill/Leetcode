namespace Easy._643.MaximumAverageSubarrayI;

/*
 * Beats 70.43% by speed and 54.81% by memory
 */
public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int result = 0, prevIndex = 0, nextResult = 0, prevResult = 0;

        for (int i = 0; i < k; ++i)
        {
            result += nums[i];
        }

        prevResult = result;
        for (int i = k; i < nums.Length; ++i)
        {
            nextResult = prevResult;
            nextResult -= nums[prevIndex++];
            nextResult += nums[i];
            prevResult = nextResult;
            if (nextResult > result)
                result = nextResult;
        }
        return (double)result / k;
    }
}
