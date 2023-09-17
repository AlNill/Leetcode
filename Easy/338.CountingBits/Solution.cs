namespace Easy._338.CountingBits;


/*
 * Beats 84.34% by speed and 82.26% by memory
 */
public class Solution
{
    private int[] iv = new int[8] { 0, 1, 1, 2, 1, 2, 2, 3 };
    public int[] CountBits(int n)
    {
        int[] result = new int[n + 1];
        if (n < 7)
        {
            for (int i = 0; i <= n; ++i)
            {
                result[i] = iv[i];
            }
            return result;
        }

        for (int i = 0; i < 8; ++i)
        {
            result[i] = iv[i];
        }

        int step = 4, counter = 8;
        while (counter < n + 1)
        {
            for (int j = 0; j < step; ++j)
            {
                if (counter == n + 1)
                    return result;
                result[counter] = result[counter - step];
                ++counter;
            }
            for (int j = 0; j < step; ++j)
            {
                if (counter == n + 1)
                    return result;
                result[counter] = result[counter - step] + 1;
                ++counter;
            }
            step *= 2;
        }

        return result;
    }
}