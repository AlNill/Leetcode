namespace Easy._492.ConstructTheRectangle;

/*
 * Beats 100% by speed and 72.22% by memory
 */
public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0 || x == 1)
            return x;

        int l = 1, r = x, m = 0;
        while (l <= r)
        {
            m = l + (r - l) / 2;
            Int64 square = (Int64)m * (Int64)m;
            if (square > (Int64)x)
                r = m - 1;
            else if (square < (Int64)x)
                l = m + 1;
            else
                return m;
        }
        return r;
    }

    public int[] ConstructRectangle(int area)
    {
        int sqrt = MySqrt(area);
        while (area % sqrt != 0)
        {
            --sqrt;
        }
        return new int[] { area / sqrt, sqrt };
    }
}
