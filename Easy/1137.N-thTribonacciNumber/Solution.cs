namespace Easy._1137.N_thTribonacciNumber;

/*
 * Beats 87.12% by speed and 59.32% by memory
 */
public class Solution
{
    public int Tribonacci(int n)
    {
        if (n < 2)
            return n;
        int tmp = 0, t0 = 0, t1 = 1, t2 = 1;
        while (n-- > 2)
        {
            tmp = t0 + t1 + t2;
            t0 = t1;
            t1 = t2;
            t2 = tmp;
        }

        return t2;
    }
}