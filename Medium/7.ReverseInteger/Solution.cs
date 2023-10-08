namespace Medium._7.ReverseInteger;

public class Solution
{
    /*
     * Beats 89.70% by speed and 23.9% by memory
     */
    public int ReverseChecked(int x)
    {
        int result = 0;
        while (x != 0)
        {
            try
            {
                checked
                {
                    result *= 10;
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            result += x % 10;
            x /= 10;
        }
        return result;
    }

    /*
     * Beats 99.13% by speed and 73.26% by memory
     */
    public int Reverse(int x)
    {
        int result = 0;
        while (x != 0)
        {
            if (result > Int32.MaxValue / 10 || result < Int32.MinValue / 10)
                return 0;
            result *= 10;
            result += x % 10;
            x /= 10;
        }
        return result;
    }
}
