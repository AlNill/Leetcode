namespace Easy._657.RobotReturnToOrigin;

/*
 * Beats 98.21% by speed and 81.61% by memory
 */
public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int x = 0, y = 0;
        for (int i = 0; i < moves.Length; ++i)
        {
            if (moves[i] == 'R')
                ++x;
            else if (moves[i] == 'L')
                --x;
            else if (moves[i] == 'U')
                ++y;
            else
                --y;
        }

        return x == 0 && y == 0;
    }
}
