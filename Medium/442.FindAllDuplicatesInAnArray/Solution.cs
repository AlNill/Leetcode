namespace Medium._442.FindAllDuplicatesInAnArray;

/*
 * Beats 94.80% by speed and 32.37% by memory
 */
public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            while (nums[nums[i] - 1] != nums[i])
            {
                var tmp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = tmp;
            }
        }

        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != i + 1)
                result.Add(nums[i]);
        }
        return result;
    }
}
