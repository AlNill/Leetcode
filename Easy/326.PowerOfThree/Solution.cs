namespace Easy._326.PowerOfThree;

/*
 * Beats 85.61% by speed and 87.97% by memory
 */
public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
            return false;

        while (n % 3 == 0)
        {
            n /= 3;
        }
        return n == 1;
    }
}
