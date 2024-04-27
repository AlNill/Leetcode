namespace Medium._46.Permutations;

/*
 * Beats 20.05% by speed and 80.47% by memory
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

    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        int[] tmp = new int[nums.Length];
        Array.Copy(nums, tmp, nums.Length);
        result.Add(tmp.ToList());

        int count = 1;
        for (int i = 1; i <= nums.Length; ++i)
        {
            count *= i;
        }

        for (int i = 0; i < count - 1; ++i)
        {
            NextPermutation(nums);
            tmp = new int[nums.Length];
            Array.Copy(nums, tmp, nums.Length);
            result.Add(tmp);
        }
        return result;
    }
}