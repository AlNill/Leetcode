namespace Easy._292.NimGame;

/*
 * Beats 87.56% by speed and 67.28% by memory
 */
public class Solution
{
    public bool CanWinNim(int n)
    {
        return !(((n & 3) == 0));
    }
}
