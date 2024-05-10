namespace Medium._47.PermutationsII;

/*
 * Beats 91.80% by speed and 61.97% by memory
 */
public class Solution
{
    public void Generate(IList<IList<int>> result, int[] nums, int pos)
    {
        if (pos == nums.Length)
        {
            int[] res = new int[nums.Length];
            Array.Copy(nums, res, nums.Length);
            result.Add(res.ToList());
            return;
        }

        for (int i = pos; i < nums.Length; ++i)
        {
            if (i > pos && nums[i] == nums[pos])
                continue;
            int tmp = nums[pos];
            nums[pos] = nums[i];
            nums[i] = tmp;
            Generate(result, nums, pos + 1);
        }

        for (int i = nums.Length - 1; i > pos; --i)
        {
            int tmp2 = nums[pos];
            nums[pos] = nums[i];
            nums[i] = tmp2;
        }
    }

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        Generate(result, nums, 0);
        return result;
    }
}
