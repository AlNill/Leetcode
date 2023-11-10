namespace Medium._36.ValidSudoku;

/*
 * Beats 39.29% by speed and 92.60% by memory
 */
public class Solution
{
    private bool CheckDublicatesInRaw(char[][] board, int rawNum)
    {
        int[] tmp = new int[9];
        for (int i = 0; i < 9; ++i)
        {
            if (board[rawNum][i] == '.')
                continue;
            ++tmp[(board[rawNum][i] - '0') - 1];
            if (tmp[(board[rawNum][i] - '0') - 1] > 1)
                return false;
        }
        return true;
    }

    private bool CheckDublicatesInCol(char[][] board, int colNum)
    {
        int[] tmp = new int[9];
        for (int i = 0; i < 9; ++i)
        {
            if (board[i][colNum] == '.')
                continue;
            ++tmp[(board[i][colNum] - '0') - 1];
            if (tmp[(board[i][colNum] - '0') - 1] > 1)
                return false;
        }
        return true;
    }

    private bool CheckDublicatesInBox(char[][] board, int boxNum)
    {
        int boxStartIndex = (boxNum % 3) * 3 + ((boxNum / 3) * 27);
        int rawNum = boxStartIndex / 9;
        int colNum = boxStartIndex % 9;
        int[] tmp = new int[9];
        for (int tmpRaw = rawNum; tmpRaw < rawNum + 3; ++tmpRaw)
        {
            for (int tmpCol = colNum; tmpCol < colNum + 3; ++tmpCol)
            {
                if (board[tmpRaw][tmpCol] == '.')
                    continue;
                ++tmp[(board[tmpRaw][tmpCol] - '0') - 1];
                if (tmp[(board[tmpRaw][tmpCol] - '0') - 1] > 1)
                    return false;
            }
        }

        return true;
    }

    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < 9; ++i)
        {
            if (!CheckDublicatesInRaw(board, i) || !CheckDublicatesInCol(board, i) ||
                !CheckDublicatesInBox(board, i))
                return false;
        }
        return true;
    }
}
