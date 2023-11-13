using Easy.Common;

namespace Easy._653.TwoSumIV_InputIsABST;

/*
 * Beats 90.98% by speed and 9.77% by memory
 */
public class Solution
{
    Dictionary<int, int> pair = new Dictionary<int, int>();

    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null)
            return false;

        if (!pair.ContainsKey(root.val))
            pair.Add(k - root.val, root.val);
        else
            return true;
        return FindTarget(root.left, k) || FindTarget(root.right, k);
    }
}