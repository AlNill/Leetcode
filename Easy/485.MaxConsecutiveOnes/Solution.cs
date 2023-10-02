namespace Easy._485.MaxConsecutiveOnes;

/*
 * Beats 70.41% by speed and 50.11% by memory
 */
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0, current = 0;
        foreach (int i in nums)
        {
            current = i == 0 ? 0 : ++current;
            max = max > current ? max : current;
        }
        return max;
    }
}
