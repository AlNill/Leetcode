using Easy.Common;

namespace Easy._226.InvertBinaryTree;

/*
 * Beats 97.96 by speed and 57.23% by memory;
 */
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;

        var tmp = root.left;
        root.left = root.right;
        root.right = tmp;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}
