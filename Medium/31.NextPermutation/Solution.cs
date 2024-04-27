namespace Medium._31.NextPermutation;

/*
 * Beats 27.01% by speed and 84.44% be memory
 */
public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length, k, l;
        for (k = n - 2; k >= 0; --k)
        {
            if (nums[k] < nums[k + 1])
                break;
        }
        if (k < 0)
        {
            Array.Sort(nums);
            return;
        }

        for (l = n - 1; l > k; --l)
        {
            if (nums[l] > nums[k])
                break;
        }

        int tmp = nums[l];
        nums[l] = nums[k];
        nums[k] = tmp;
        Array.Reverse(nums, k + 1, nums.Length - k - 1);
    }
}
