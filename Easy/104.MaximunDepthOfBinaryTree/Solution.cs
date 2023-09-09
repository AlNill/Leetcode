using Easy.Common;

namespace Easy._104.MaximunDepthOfBinaryTree;

/*
 * As result code beats 78.93% by runtime and 91.69% by memory.
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
}
