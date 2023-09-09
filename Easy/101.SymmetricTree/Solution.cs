using Easy.Common;

namespace Easy._101.SymmetricTree;

/*
 * As result code beats 76.38% by runtime and 77.61% by memory.
 */
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root.left != null && root.right != null)
            return IsEqual(root.left, root.right);
        return root.left == null && root.right == null;
    }

    public bool IsEqual(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
            return true;
        if (left == null || right == null || left.val != right.val)
            return false;
        return IsEqual(left.left, right.right) && IsEqual(left.right, right.left);
    }
}
