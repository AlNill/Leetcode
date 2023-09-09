namespace _169.MajorityElement;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int n = nums.Length;
        int max = nums[0];
        int count = 1;
        for (int i = 0; i < n; ++i)
        {
            if (nums[i] == max)
            {
                ++count;
            }
            else
            {
                --count;
                if (count == 0)
                {
                    max = nums[i];
                    count = 1;
                }
            }
        }
        return max;
    }
}
