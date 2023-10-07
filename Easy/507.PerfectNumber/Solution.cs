namespace Easy._507.PerfectNumber;

/*
 * Beats 69.96% by speed and 79.37% by memory
 */
public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        if (num == 1)
            return false;
        int result = 1;
        int mid = (int)Math.Sqrt(num);
        for (int i = 2; i <= mid; ++i)
        {
            if (num % i == 0)
                result += i + num / i;
        }
        return num == result;
    }
}
