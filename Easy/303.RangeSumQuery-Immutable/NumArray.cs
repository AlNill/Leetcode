namespace Easy._303.RangeSumQuery_Immutable;

/*
 * Beats 99.66% by speed and 80.81% by memory
 */
public class NumArray
{
    private int[] _nums;

    public NumArray(int[] nums)
    {
        _nums = nums;
        for (int i = 1; i < nums.Length; ++i)
        {
            _nums[i] = _nums[i - 1] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        if (left == 0)
            return _nums[right];
        return _nums[right] - _nums[left - 1];
    }
}
