namespace Easy._202.HappyNumber;

public class Solution
{
    private int TwoStepDigitsSum(int n)
    {
        int tmp = DigitsSum(n);
        return DigitsSum(tmp);
    }

    private int DigitsSum(int n)
    {
        int tmp = 0;
        while (n != 0)
        {
            tmp += (int)Math.Pow(n % 10, 2);
            n /= 10;
        }
        return tmp;
    }

    /*
     * Beats 67.32% by speed and 91.45% by memory
     */
    public bool FloydIsHappy(int n)
    {
        int slow = n, fast = n;
        do
        {
            slow = DigitsSum(slow);
            fast = TwoStepDigitsSum(fast);
        } while (slow != fast);
        return slow == 1;
    }


    /*
     * Beats 96.61% by speed and 26.67% by memory
     */
    public bool IsHappy(int n)
    {
        HashSet<int> results = new HashSet<int>();
        results.Add(n);
        while (true)
        {
            int tmp = 0;
            while (n != 0)
            {
                tmp += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }
            if (tmp == 1)
                return true;
            if (results.Contains(tmp))
                return false;
            results.Add(tmp);
            n = tmp;
        }
        return false;
    }
}
