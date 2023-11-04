using Easy.Common;

namespace Easy._530.MinimumAbsoluteDifferenceInBST;

/*
 * Beats 92.31% by speed and 29.06% by memory
 */
public class Solution
{
    int _result = Int32.MaxValue;
    int _prev = Int32.MaxValue;

    public int GetMinimumDifference(TreeNode root)
    {
        if (root == null)
            return _result;

        GetMinimumDifference(root.left);
        if (_prev != Int32.MaxValue)
            _result = Math.Min(_result, root.val - _prev);
        _prev = root.val;

        GetMinimumDifference(root.right);
        return _result;
    }
}
