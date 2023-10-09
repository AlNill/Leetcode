namespace Medium._11.ContainerWithMostWater;

public class Solution
{
    /*
     * Beats 88.27% by speed and 72.70% by memory
     */
    public int MaxArea(int[] height)
    {
        int max = 0;
        int i = 0, j = height.Length - 1;
        while (i < j)
        {
            int h = Math.Min(height[i], height[j]);
            max = Math.Max(max, h * (j - i));
            while (i < j && height[j] <= h) { --j; }
            while (i < j && height[i] <= h) { ++i; }
        }
        return max;
    }

    /*
     * Time limit exceeded
     * O(n^2)
     */
    public int MaxAreaLong(int[] height)
    {
        int max = 0;
        for (int i = 0; i < height.Length - 1; ++i)
        {
            for (int j = i + 1; j < height.Length; ++j)
            {
                int area = (j - i) * Math.Min(height[i], height[j]);
                if (max < area)
                    max = area;
            }
        }
        return max;
    }
}