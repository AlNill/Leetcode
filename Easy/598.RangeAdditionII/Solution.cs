namespace Easy._598.RangeAdditionII;

public class Solution
{
    /*
     * Beats 67.44% by speed and 18.60% by memory
     */
    public int MaxCountShort(int m, int n, int[][] ops)
    {
        if (ops.Length == 0)
            return m * n;
        return ops.Select(x => x[0]).ToArray().Min() * ops.Select(x => x[1]).ToArray().Min();
    }

    /*
     * Beats 97.67% by speed and 18.60% by memory
     */
    public int MaxCount(int m, int n, int[][] ops)
    {
        if (ops.Length == 0)
            return m * n;
        int raw = ops[0][0], col = ops[0][1];
        for (int i = 1; i < ops.Length; ++i)
        {
            if (ops[i][0] < raw)
                raw = ops[i][0];
            if (ops[i][1] < col)
                col = ops[i][1];
        }

        return raw * col;
    }
}
