namespace _70.ClimbingStairs;

public class Solution
{
    public int ClimbStairs(int n)
    {
        int[] ints = new int[n + 1];
        ints[0] = 1;
        ints[1] = 1;

        for(int i = 2; i <= n; ++i)
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
