namespace Easy._771.JewelsAndStones;

/*
 * Beats 96.22% by speed and 33.89% by memory
 */
public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int totalCount = 0;
        HashSet<char> jewelsSet = new HashSet<char>();
        for (int i = 0; i < jewels.Length; ++i)
        {
            jewelsSet.Add(jewels[i]);
        }

        for (int i = 0; i < stones.Length; ++i)
        {
            if (jewelsSet.Contains(stones[i]))
                ++totalCount;
        }
        return totalCount;
    }
}
