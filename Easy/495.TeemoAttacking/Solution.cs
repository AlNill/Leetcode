namespace Easy._495.TeemoAttacking;

/*
 * Beats 88.44% by speed and 64.63% by memory
 */
public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int result = 0, prevPoisonAttack = timeSeries[0];
        foreach (int second in timeSeries)
        {
            int time = second - prevPoisonAttack;
            result += time > duration ? duration : time;
            prevPoisonAttack = second;
        }
        result += duration;
        return result;
    }
}
