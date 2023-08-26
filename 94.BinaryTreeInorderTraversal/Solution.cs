using System.Xml.Linq;

namespace _94.BinaryTreeInorderTraversal;

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
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        if (root == null)
            return result;
        Inorder(root, result);
        return result;
    }

    public void Inorder(TreeNode node, IList<int> result)
    {
        if (node == null)
            return;
        if (node.left != null)
            Inorder(node.left, result);
        result.Add(node.val);
        if (node.right != null)
            Inorder(node.right, result);
    }
}
