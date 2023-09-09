namespace Easy._118.PascalsTriangle;

/*
 * As result code beats 82.9% by runtime and 22.11% by memory.
 */
public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>() { 1 });

        for (int i = 2; i <= numRows; ++i)
        {
            List<int> nums = new List<int>() { 1 };
            IList<int> prev = result[i - 2];
            for (int j = 1; j < i; ++j)
            {
                if (j != i - 1)
                {
                    nums.Add(prev[j - 1] + prev[j]);
                    continue;
                }
                nums.Add(1);
            }
            result.Add(nums);
        }
        return result;
    }
}
