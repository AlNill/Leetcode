namespace _145.BinaryTreePostorderTraversal;

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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        PostorderTraversal(root, result);
        return result;
    }

    public void PostorderTraversal(TreeNode root, IList<int> result)
    {
        if (root == null)
            return;

        PostorderTraversal(root.left, result);
        PostorderTraversal(root.right, result);
        result.Add(root.val);
    }
}
