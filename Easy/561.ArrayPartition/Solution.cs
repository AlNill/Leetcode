namespace Easy._561.ArrayPartition;

public class Solution
{
    /*
     * Beats 98.46% O(N) solution by speed and 5.2% by memory
     */
    public int ArrayPairSumFast(int[] nums)
    {
        int result = 0;
        int[] sorted = new int[20001];
        for (int i = 0; i < nums.Length; ++i)
        {
            ++sorted[nums[i] + 10000];
        }

        bool notHasPair = true;
        for (int i = 0; i < 20001; ++i)
        {
            while (sorted[i] > 0)
            {
                if (notHasPair)
                    result += i - 10000;
                notHasPair = !notHasPair;
                --sorted[i];
            }
        }

        return result;
    }

    /*
     * Beats 61.39% O(NLogN) solution by speed and 66.41% by memory
     */
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);
        int result = 0;
        for (int i = 0; i < nums.Length;)
        {
            result += Math.Min(nums[i], nums[i + 1]);
            i += 2;
        }
        return result;
    }
}
