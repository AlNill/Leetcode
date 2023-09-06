﻿namespace _104.MaximumDepthOfBinaryTree;

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
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        int lDepth = MaxDepth(root.left);
        int rDepth = MaxDepth(root.right);

        return lDepth > rDepth ? lDepth + 1 : rDepth + 1;
    }
}