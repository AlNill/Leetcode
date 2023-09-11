using Easy.Common;

namespace Easy._222.CountCompleteTreeNodes;

/*
 * Beats 77.34% by speed and Beats 26.11% by memory
 */
public class Solution
{
    public int GetLeftHeight(TreeNode root)
    {
        if (root == null)
            return 0;
        return GetLeftHeight(root.left) + 1;
    }

    public int GetRightHeight(TreeNode root)
    {
        if (root == null)
            return 0;
        return GetRightHeight(root.right) + 1;
    }

    public int CountNodes(TreeNode root)
    {
        int rightHeight = GetRightHeight(root);
        int leftHeight = GetLeftHeight(root);

        if (rightHeight == leftHeight)
            return (int)Math.Pow(2, rightHeight) - 1;

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}
