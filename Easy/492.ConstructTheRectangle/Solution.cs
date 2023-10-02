namespace Easy._492.ConstructTheRectangle;

/*
 * Beats 78.89% by speed and 30% by memory
 */
public class Solution
{
    public int[] ConstructRectangle(int area)
    {
        int sqrt = (int)Math.Sqrt(area);
        while (area % sqrt != 0)
        {
            --sqrt;
        }
        return new int[] { area / sqrt, sqrt };
    }
}
