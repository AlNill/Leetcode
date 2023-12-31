﻿namespace Easy._455.AssignCookies;

/*
 * Beats 71.92% by speed and 65.75% by memory
 */
public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int i = 0, j = 0;
        while (i < g.Length && j < s.Length)
        {
            if (g[i] <= s[j])
                ++i;
            ++j;
        }
        return i;
    }
}
