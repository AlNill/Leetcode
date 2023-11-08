namespace Easy._566.ReshapeTheMatrix;

/*
 * Beats 85.23% by speed and 70.45% by memory
 */
public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int originalRawCount = mat.Length;
        int originalColumnCount = mat[0].Length;
        if (originalRawCount * originalColumnCount != r * c)
            return mat;

        int[][] result = new int[r][];
        for (int i = 0; i < r; ++i)
            result[i] = new int[c];

        for (int i = 0; i < originalRawCount * originalColumnCount; ++i)
        {
            result[i / c][i % c] = mat[i / originalColumnCount][i % originalColumnCount];
        }
        return result;
    }
}
