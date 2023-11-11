namespace Medium._39.CombinationSum;

/*
 * Beats 76.79% by speed and 38.11% be memory
 */
public class Solution
{
    private List<IList<int>> _result = new List<IList<int>>();

    private void FillCombination(int[] candidates, int target, List<int> comb, int index, int currentSum)
    {
        if (currentSum > target)
            return;
        if (currentSum == target)
        {
            List<int> tmp = new List<int>(comb);
            _result.Add(tmp);
        }

        for (int i = index; i < candidates.Length; ++i)
        {
            comb.Add(candidates[i]);
            currentSum += candidates[i];
            FillCombination(candidates, target, comb, i, currentSum);
            comb.RemoveAt(comb.Count - 1);
            currentSum -= candidates[i];
        }
    }

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {

        List<int> comb = new List<int>();
        FillCombination(candidates, target, comb, 0, 0);
        return _result;
    }
}
