namespace Medium._36.ValidSudoku;

/*
 * Beats 84.18% by speed and 29.40% by memory
 */
public class Solution2
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<string> values = new HashSet<string>();
        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                char val = board[i][j];
                if (val == '.')
                    continue;
                string rawConst = $"{val} in raw {i}";
                string colConst = $"{val} in col {j}";
                string blockConst = $"{val} in block {i / 3}-{j / 3}";
                if (values.Contains(rawConst) ||
                    values.Contains(colConst) ||
                    values.Contains(blockConst))
                    return false;

                values.Add(rawConst);
                values.Add(colConst);
                values.Add(blockConst);
            }
        }
        return true;
    }
}
