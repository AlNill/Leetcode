using Easy.Common;

namespace Easy._257.BinaryTreePaths;

/*
 * Beats 84.68% by speed and 40.54% by memeory
 */
public class Solution
{
    private bool IsLeaf(TreeNode root)
    {
        return root.left == null && root.right == null;
    }

    private void PathToLeaf(TreeNode root, string path, IList<string> result)
    {
        if (IsLeaf(root))
        {
            result.Add(path += $"->{root.val}");
            return;
        }

        if (root.left != null)
            PathToLeaf(root.left, path + $"->{root.val}", result);
        if (root.right != null)
            PathToLeaf(root.right, path + $"->{root.val}", result);
    }

    public IList<string> BinaryTreePaths(TreeNode root)
    {
        IList<string> result = new List<string>();
        if (root.left == null && root.right == null)
        {
            result.Add($"{root.val}");
            return result;
        }

        string startPath = $"{root.val}";
        if (root.left != null)
            PathToLeaf(root.left, startPath, result);
        if (root.right != null)
            PathToLeaf(root.right, startPath, result);
        return result;
    }
}
