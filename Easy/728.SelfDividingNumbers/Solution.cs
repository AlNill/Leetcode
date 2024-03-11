namespace Easy._728.SelfDividingNumbers;

/*
 * Beats 68.32% by speed and 63.67% by memory
 */
public class Solution
{
    private bool IsSelfDivingNumber(int num)
    {
        for (int i = num; i > 0; i /= 10)
        {
            int remainder = i % 10;
            if (remainder == 0 || num % remainder != 0)
                return false;
        }
        return true;
    }

    public IList<int> SelfDividingNumbers(int left, int right)
    {
        IList<int> result = new List<int>();
        while (left <= right)
        {
            if (IsSelfDivingNumber(left))
            {
                result.Add(left);
            }
            ++left;
        }
        return result;
    }
}
