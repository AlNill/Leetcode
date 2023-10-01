namespace Easy._476.NumberComplement;

/*
 * Beats 63% by speed and 61% by memory.
 */
public class Solution
{
    private int GetMaxOneBitPosition(int num)
    {
        int maxPosition = 0;
        while (num > 0)
        {
            ++maxPosition;
            num = num >> 1;
        }
        return maxPosition;
    }

    public int FindComplement(int num)
    {
        int tmp = 0;
        int maxPosition = GetMaxOneBitPosition(num);
        for (int i = 0; i < maxPosition; ++i)
        {
            num = num ^ (1 << i);
        }
        return num;
    }
}