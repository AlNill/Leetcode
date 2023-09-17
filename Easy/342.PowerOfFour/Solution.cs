namespace Easy._342.PowerOfFour;

/*
 * Beats 79.17% by speed and 33.68% by memory
 */
public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
            return false;

        int tmp = n, counter = 0;
        for (int i = 0; i < 31; ++i)
        {
            int result = tmp & 1;
            if (result == 1)
                ++counter;
            tmp = tmp >> 1;
        }

        if (counter != 1)
            return false;

        for (int i = 0; i < 31; ++i)
        {
            int result = n & 1;
            if (result == 1)
                return true;
            n = n >> 2;
        }
        return false;
    }
}