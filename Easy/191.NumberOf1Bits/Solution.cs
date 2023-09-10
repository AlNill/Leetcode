namespace Easy._191.NumberOf1Bits;

/*
 * Beats 87.38% by speed and Beats 97.69% by memory
 */
public class Solution
{
    public int HammingWeight(uint n)
    {
        int counter = 0;
        for (int i = 0; i < 32; ++i)
        {
            uint lastBit = n & 1;
            if (lastBit == 1)
                ++counter;
            n = n >> 1;
        }
        return counter;
    }
}
