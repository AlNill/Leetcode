namespace _101.SymmetricTree;


public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root.left != null && root.right != null)
            return IsEqual(root.left, root.right);
        return root.left == null && root.right == null;
    }

    public bool IsEqual(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
            return true;
        if (left == null || right == null || left.val != right.val)
            return false;
        return IsEqual(left.left, right.right) && IsEqual(left.right, right.left);
    }
}
