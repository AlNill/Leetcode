namespace _35.SearchInsertPosition;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, m = 0;
        while(l <= r)
        {
            m = (l + r) / 2;
            if (l == r)
                return m + 1;
            else if (nums[m] < target)
                l = m + 1;
            else if (nums[m] > target)
                r = m - 1;
            else
                return m;
        }
        return nums.Length;
    }
}
