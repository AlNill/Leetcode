namespace Easy._35.SearchInsertPosition;

/*
 * As result code beats 90.62% by runtime and 74.30% by memory.
 */
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, m = 0;
        while (l <= r)
        {
            m = (l + r) / 2;
            if (nums[m] < target)
                l = m + 1;
            else if (nums[m] > target)
                r = m - 1;
            else
                return m;
        }
        return l;
    }
}
