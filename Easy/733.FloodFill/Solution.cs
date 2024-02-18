namespace Easy._733.FloodFill;

/*
 * Beats 74.62% by speed and 92.05% by memory
 */
public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        Fill(image, sr, sc, color, image[sr][sc]);
        return image;
    }

    private void Fill(int[][] image, int sr, int sc, int color, int oldColor)
    {
        if (sr < 0
            || sr >= image.Length
            || sc < 0
            || sc >= image[0].Length
            || image[sr][sc] != oldColor
            || image[sr][sc] == color)
            return;

        image[sr][sc] = color;
        Fill(image, sr - 1, sc, color, oldColor);
        Fill(image, sr, sc - 1, color, oldColor);
        Fill(image, sr + 1, sc, color, oldColor);
        Fill(image, sr, sc + 1, color, oldColor);
    }
}