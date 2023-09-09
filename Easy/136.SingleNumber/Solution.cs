namespace Easy._136.SingleNumber;

/*
 * As result code beats 93.02% by runtime and 83.90% by memory.
 */
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            result ^= nums[i];
        }
        return result;
    }
}
