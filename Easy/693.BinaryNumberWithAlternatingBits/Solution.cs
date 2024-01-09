namespace Easy._693.BinaryNumberWithAlternatingBits;

/*
 * Beats 100% by speed and 60% by memory
 */
public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        n = n ^ (n >> 1);
        return (n & n + 1) == 0;
    }
}