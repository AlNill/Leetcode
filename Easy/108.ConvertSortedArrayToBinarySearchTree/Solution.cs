#nullable disable
using Easy.Common;
namespace Easy._108.ConvertSortedArrayToBinarySearchTree;

/*
 * As result code beats 96.35% by runtime and 51.16% by memory.
 */
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
