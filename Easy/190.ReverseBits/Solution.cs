namespace Easy._190.ReverseBits;

/*
 * Beats 57.40% by speed and Beats 68.89% by memory
 */
public class Solution
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 32; ++i)
        {
            result = result << 1;
            uint isBitSet = n & (uint)1;
            if (isBitSet == 1)
                ++result;
            n = n >> 1;
        }
        return result;
    }
}
