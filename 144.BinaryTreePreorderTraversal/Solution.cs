namespace _144.BinaryTreePreorderTraversal;

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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        PreorderTraversal(root, result);
        return result;
    }

    public void PreorderTraversal(TreeNode root, IList<int> result)
    {
        if (root == null)
            return;
        result.Add(root.val);
        PreorderTraversal(root.left, result);
        PreorderTraversal(root.right, result);
    }
}
