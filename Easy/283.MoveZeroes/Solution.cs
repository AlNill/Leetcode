﻿namespace Easy._283.MoveZeroes;

/*
 * Beats 90.99% by speed and 31.26% by memory
 */
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int window = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
                ++window;
            else
            {
                int tmp = nums[i];
                nums[i] = 0;
                nums[i - window] = tmp;
            }
        }
    }
}
