namespace Easy._509.FibonacciNumber;

public class Solution
{
    /*
     * Use nex formula https://r-knott.surrey.ac.uk/Fibonacci/fibFormula.html
     * O(1) speed
     * O(1) memory
     * Beats 78.12% by speed and 68.12% by memory
     */
    public int FibFormula(int n)
    {
        double p = (Math.Sqrt(5) + 1) / 2;
        return (int)Math.Round(Math.Pow(p, n) / Math.Sqrt(5));
    }

    /*
     * Beats 75.4% by speed and 68.12% by memory
     */
    public int FibMemorize2(int n)
    {
        if (n <= 1)
            return n;
        int first = 0, second = 1, result = 0;
        for (int i = 2; i < n + 1; ++i)
        {
            result = first + second;
            first = second;
            second = result;
        }
        return result;
    }

    /*
     * Beats 42.56% by speed and 94.87% by memory
     */
    public int FibMemorizeAll(int n)
    {
        if (n <= 1)
            return n;
        int[] resultArr = new int[n + 1];
        resultArr[0] = 0;
        resultArr[1] = 1;
        for (int i = 2; i < n + 1; ++i)
            resultArr[i] = resultArr[i - 1] + resultArr[i - 2];
        return resultArr[n];
    }

    /*
     * O(2 ^ n) speed
     * O(n) memory
     * Beats 26.50% by speed and 94.87% by memory
     */
    public int FibRecursion(int n)
    {
        if (n <= 1)
            return n;
        return FibRecursion(n - 1) + FibRecursion(n - 2);
    }
}
