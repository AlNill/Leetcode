namespace Easy._228.SummaryRanges;

/*
 * Beats 84.65% by speed and 30.86% by memory
 */
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < nums.Length; ++i)
        {
            int j = i;
            while (j + 1 < nums.Length && nums[j] + 1 == nums[j + 1])
            {
                ++j;
            }

            string range = i == j ? $"{nums[i]}" : $"{nums[i]}->{nums[j]}";
            result.Add(range);
            i = j;
        }
        return result.ToArray();
    }
}
