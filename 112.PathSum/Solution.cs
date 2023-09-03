namespace _112.PathSum;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
            return false;
        int currentSum = root.val;
        if (currentSum == targetSum && IsLeaf(root))
            return true;
        return CalcSumToLeaf(root.left, targetSum, currentSum) || CalcSumToLeaf(root.right, targetSum, currentSum);
    }

    public bool IsLeaf(TreeNode root)
    {
        return root.left == null && root.right == null;
    }

    public bool CalcSumToLeaf(TreeNode root, int targetSum, int currentSum)
    {
        if (root == null)
            return false;
        if (IsLeaf(root))
            return targetSum == (currentSum + root.val);

        currentSum += root.val;
        return CalcSumToLeaf(root.left, targetSum, currentSum) || CalcSumToLeaf(root.right, targetSum, currentSum);
    }
}
