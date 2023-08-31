namespace _108.ConvertSortedArrayToBinarySearchTree;

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
    public TreeNode RecursiveBuild(int[] nums, int left, int right)
    {
        if (left > right)
            return null;
        int middle = (right + left) / 2;
        TreeNode root = new TreeNode(nums[middle]);
        root.left = RecursiveBuild(nums, left, middle - 1);
        root.right = RecursiveBuild(nums, middle + 1, right);
        return root;
    }

    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 1)
            return new TreeNode(nums[0]);
        return RecursiveBuild(nums, 0, nums.Length - 1);
    }
}
