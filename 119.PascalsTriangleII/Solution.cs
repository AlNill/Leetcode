﻿namespace _119.PascalsTriangleII;

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        IList<int> current = new List<int>() { 1 };
        for (int i = 2; i <= rowIndex + 1; ++i)
        {
            var tmp = new List<int>() { 1 };
            for (int j = 1; j < i; ++j)
            {
                if (j != i - 1)
                    tmp.Add(current[j - 1] + current[j]);
                else
                    tmp.Add(1);
            }
            current = tmp;
        }
        return current;
    }
}
