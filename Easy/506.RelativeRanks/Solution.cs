namespace Easy._506.RelativeRanks;

/*
 * Beats 83.43% by speed and 72.19% by memory
 */
public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        Dictionary<int, int> storage = new Dictionary<int, int>();
        for (int i = 0; i < score.Length; ++i)
        {
            storage.Add(score[i], i);
        }

        string[] result = new string[score.Length];
        Array.Sort(score, (x, y) => y.CompareTo(x));
        for (int i = 3; i < score.Length; ++i)
        {
            result[storage[score[i]]] = $"{i + 1}";
        }

        if (score.Length > 0)
            result[storage[score[0]]] = "Gold Medal";
        if (score.Length > 1)
            result[storage[score[1]]] = "Silver Medal";
        if (score.Length > 2)
            result[storage[score[2]]] = "Bronze Medal";

        return result;
    }
}
