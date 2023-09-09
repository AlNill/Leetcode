using Easy.Common;

namespace Easy._100.SameTree;

/*
As result code beats 75.30% by runtime and 38.25% by memory.
*/
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null || p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
