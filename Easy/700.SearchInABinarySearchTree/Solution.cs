using Easy.Common;

namespace Easy._700.SearchInABinarySearchTree;

/*
 * Beats 82.11% by speed and 11.65% by memory
 */
public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null)
            return null;
        if (root.val == val)
            return root;
        var result = SearchBST(root.left, val);
        if (result != null)
            return result;
        return SearchBST(root.right, val);
    }
}
