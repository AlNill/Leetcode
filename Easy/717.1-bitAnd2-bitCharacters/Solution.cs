namespace Easy._717._1_bitAnd2_bitCharacters;

/*
 * Beats 69.70% by speed and 56.06% by memory
 */
public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        if (bits[bits.Length - 1] == 1)
            return false;

        int i = 0;
        while (i < bits.Length - 1)
        {
            if (bits[i] == 1)
                ++i;
            ++i;
        }

        return !(i > bits.Length - 1);
    }
}
