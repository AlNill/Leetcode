namespace Easy._231.PowerOfTwo;

/*
 * Beats 79.67% by speed and 47.74% by memory
 */
public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n < 0)
            return false;
        bool isExistOne = false;
        for (int i = 0; i < 31; ++i)
        {
            int lastBit = n & 1;
            if (lastBit == 1)
            {
                if (isExistOne)
                    return false;
                isExistOne = true;
            }
            n = n >> 1;
        }
        return isExistOne == true ? true : false;
    }
}
