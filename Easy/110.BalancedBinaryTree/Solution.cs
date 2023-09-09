using Easy.Common;
namespace Easy._110.BalancedBinaryTree;

/*
 * As result code beats 61.24% by runtime and 79.01% by memory.
 */
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        int lDepth = MaxDepth(root.left);
        int rDepth = MaxDepth(root.right);

        return lDepth > rDepth ? lDepth + 1 : rDepth + 1;
    }

    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
            return true;

        int leftHeight = MaxDepth(root.left);
        int rightHeight = MaxDepth(root.right);
        return Math.Abs(leftHeight - rightHeight) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
}
