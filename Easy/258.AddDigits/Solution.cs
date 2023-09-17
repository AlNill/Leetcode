namespace Easy._258.AddDigits;

/*
 * Beats 85.6% by speed and 84.48% by memory
 */
public class Solution
{
    public int AddDigits(int num)
    {
        if (num == 0)
            return 0;
        int result = num % 9;
        return result == 0 ? 9 : result;
    }
}
