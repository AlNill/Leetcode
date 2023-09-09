using Easy.Common;
namespace Easy._111.MinimumDepthOfBinaryTree;

/*
 * As result code beats 76.55% by runtime and 94.92% by memory.
 */
public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        if (root.left == null && root.right == null)
            return 1;
        if (root.left == null)
            return MinDepth(root.right) + 1;
        if (root.right == null)
            return MinDepth(root.left) + 1;

        return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
}
