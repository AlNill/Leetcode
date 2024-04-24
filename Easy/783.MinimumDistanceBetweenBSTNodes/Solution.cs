using Easy.Common;

namespace Easy._783.MinimumDistanceBetweenBSTNodes;

/*
 * Beats 71.15% by speed and 42.31% by memory
 */
public class Solution
{
    private int _result = Int32.MaxValue;
    private int _prev = Int32.MaxValue;

    public int MinDiffInBST(TreeNode root)
    {
        if (root.left != null)
            MinDiffInBST(root.left);
        if (_prev != Int32.MaxValue)
            _result = Math.Min(_result, Math.Abs(_prev - root.val));
        _prev = root.val;
        if (root.right != null)
            MinDiffInBST(root.right);
        return _result;
    }
}
