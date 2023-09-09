namespace Easy._70.ClimbingStairs;

/*
 * As result code beats 94.94% by runtime and 18.29% by memory.
 * As result code beats 85.65% by runtime and 67.81% by memory with method on Less Memory.
 */
public class Solution
{
    public int ClimbStairs(int n)
    {
        int[] ints = new int[n + 1];
        ints[0] = 1;
        ints[1] = 1;

        for (int i = 2; i <= n; ++i)
        {
            ints[i] = ints[i - 1] + ints[i - 2];
        }

        return ints[n];
    }

    public int ClimbStairsLessMemory(int n)
    {
        if (n == 1)
            return 1;

        int prev = 1, prevprev = 1, result = 0;
        for (int i = 2; i <= n; ++i)
        {
            result = prev + prevprev;
            prevprev = prev;
            prev = result;
        }

        return result;
    }
}


