namespace Easy._263.UglyNumber;

/*
 * Beats 77.15% by speed and 63.50% by memory
 */
public class Solution
{
    public bool IsUgly(int n)
    {
        if (n <= 0)
            return false;

        while (n >= 0)
        {
            if (n == 1)
                return true;
            else if (n % 2 == 0)
                n /= 2;
            else if (n % 3 == 0)
                n /= 3;
            else if (n % 5 == 0)
                n /= 5;
            else
                return false;
        }

        return true;
    }
}
