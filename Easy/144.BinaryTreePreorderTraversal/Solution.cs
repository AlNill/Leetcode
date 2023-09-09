using Easy.Common;
namespace Easy._144.BinaryTreePreorderTraversal;

/*
 * As result code beats 72.46% by runtime and 78.52% by memory.

EXPLANATION PREORDER TRAVERSAL:
	Follow the below steps to implement the idea:
	1. Visit the root and print the data.
	2. Traverse left subtree
	3. Traverse the right subtree
 */
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