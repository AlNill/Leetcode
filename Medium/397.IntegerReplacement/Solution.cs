namespace Medium._397.IntegerReplacement;

/*
 * Beats 100% by speed and 67.86% by memory
 */
public class Solution
{
    public int IntegerReplacement(int n)
    {
        if (n == 1)
            return 0;
        int counter = 0;
        long tmp = (long)n;
        while (tmp != 1)
        {
            if ((tmp & 1) == 0)
            {
                tmp = tmp >> 1;
            }
            else
            {
                if (tmp != 3 && (tmp & 2) == 2)
                    ++tmp;
                else
                    --tmp;
            }
            ++counter;
        }
        return counter;
    }
}
