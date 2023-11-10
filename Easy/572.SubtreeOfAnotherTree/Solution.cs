using Easy.Common;

namespace Easy._572.SubtreeOfAnotherTree;

/*
 * Beats 81.28% by speed and 50.62% by memory
 */
public class Solution
{
    private bool Compare(TreeNode lRoot, TreeNode rRoot)
    {
        if (lRoot == null && rRoot == null)
            return true;
        if (lRoot == null || rRoot == null || lRoot.val != rRoot.val)
            return false;

        return Compare(lRoot.left, rRoot.left) && Compare(lRoot.right, rRoot.right);
    }

    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null)
            return false;
        if (Compare(root, subRoot))
            return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
}
