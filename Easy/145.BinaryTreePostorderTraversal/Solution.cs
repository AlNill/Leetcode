using Easy.Common;
namespace Easy._145.BinaryTreePostorderTraversal;

/*
 * 
 */
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

