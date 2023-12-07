using Easy.Common;

namespace Easy._671.SecondMinimumNodeInABinaryTree;

/*
 * Beats 100% by speed and 60.47% by memory;
 */
public class Solution
{
    private int _min = 0;
    private int _second = Int32.MaxValue;
    private bool _isSecond = false;

    public int FindSecondMinimumValue(TreeNode root)
    {
        if (root == null || root.left == null)
            return -1;

        _min = Math.Min(root.left.val, root.right.val);
        Find(root.left);
        Find(root.right);
        return _isSecond == true ? _second : -1;
    }

    private void Find(TreeNode root)
    {
        if (root.val != _min)
        {
            _second = root.val < _second ? root.val : _second;
            _isSecond = true;
            return;
        }

        if (root.left == null)
            return;

        Find(root.left);
        Find(root.right);
    }
}