namespace Easy._605.CanPlaceFlowers;

/*
 * Beats 97.16% by spped and 33.10% by memory
 */
public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
            return true;

        for (int i = 0; i < flowerbed.Length; ++i)
        {
            if ((i == 0 || flowerbed[i - 1] == 0) &&
               (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0) &&
                flowerbed[i] == 0)
            {
                --n;
                flowerbed[i] = 1;
                if (n == 0)
                    return true;
            }
        }
        return false;
    }
}
