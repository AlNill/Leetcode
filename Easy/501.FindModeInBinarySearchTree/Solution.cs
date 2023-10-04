using Easy.Common;

namespace Easy._501.FindModeInBinarySearchTree;

/*
 * Beats 87.50% by speed and 84.09% by memory
 */
public class Solution
{
    private int _max = 0;
    private int _currentCount = 0;
    private int _currentVal = 100001;

    public int[] FindMode(TreeNode root)
    {
        HashSet<int> result = new HashSet<int>();
        if (root == null)
            return result.ToArray();

        FindMode(root, result);
        return result.ToArray();
    }

    public void FindMode(TreeNode root, HashSet<int> result)
    {
        if (root == null)
            return;
        FindMode(root.left, result);
        if (root.val != _currentVal)
        {
            _currentVal = root.val;
            _currentCount = 1;
        }
        else
            ++_currentCount;

        if (_currentCount > _max)
        {
            result.Clear();
            result.Add(root.val);
            _max = _currentCount;
        }

        if (_currentCount == _max)
            result.Add(root.val);
        FindMode(root.right, result);
    }
}
