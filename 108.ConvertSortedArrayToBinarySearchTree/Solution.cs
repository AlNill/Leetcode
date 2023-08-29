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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 1)
            return new TreeNode(nums[0]);
        int midPosition = nums.Length / 2;
        TreeNode root = new TreeNode(nums[midPosition]);
        var tmp = root;
        for (int i = midPosition - 1; i >= 0; --i)
        {
            tmp.left = new TreeNode(nums[i]);
            tmp = tmp.left;
        }
        tmp = root;
        for (int j = midPosition + 1; j < nums.Length; ++j)
        {
            tmp.right = new TreeNode(nums[j]);
            tmp = tmp.right;
        }
        return root;
    }
}
