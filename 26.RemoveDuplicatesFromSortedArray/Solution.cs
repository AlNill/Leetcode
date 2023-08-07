namespace _26.RemoveDuplicatesFromSortedArray;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        List<int> result = new List<int>();
        int current = nums[0];
        int pos = 1;
        result.Add(current);

        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] != current)
            {
                current = nums[i];
                nums[pos++] = current;
                result.Add(current);
            }
        }
        return result.Count;
    }
}
