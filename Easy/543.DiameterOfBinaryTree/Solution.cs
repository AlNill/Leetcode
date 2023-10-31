using Easy.Common;

namespace Easy._543.DiameterOfBinaryTree;

/*
 * Beats 96.59% by speed and 48.99% by memory
 */
public class Solution
{
    private int dfs(TreeNode root, ref int d)
    {
        if (root == null)
            return 0;
        var left = dfs(root.left, ref d);
        var right = dfs(root.right, ref d);
        d = Math.Max(d, left + right);
        return Math.Max(left, right) + 1;
    }

    public int DiameterOfBinaryTree(TreeNode root)
    {
        int d = 0;
        dfs(root, ref d);
        return d;
    }
}
