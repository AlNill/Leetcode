namespace Easy._441.ArrangingCoins;

/*
 * Beats 93.81% by speed and 34.51% by memory
 */
public class Solution
{
    public int ArrangeCoins(int n)
    {
        long tmp = n;
        return (int)((Math.Sqrt(8 * tmp + 1) - 1) / 2);
    }
}