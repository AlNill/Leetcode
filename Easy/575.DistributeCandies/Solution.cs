namespace Easy._575.DistributeCandies;

/*
 * Beats 90.30% by speed and 41.79% by memory
 */
public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        HashSet<int> candiesTypes = new HashSet<int>();
        int maxCandies = candyType.Length / 2;
        for (int i = 0; i < candyType.Length; ++i)
        {
            candiesTypes.Add(candyType[i]);
        }
        return Math.Min(candiesTypes.Count, maxCandies);
    }
}
