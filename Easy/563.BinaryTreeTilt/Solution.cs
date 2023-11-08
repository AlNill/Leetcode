using Easy.Common;

namespace Easy._563.BinaryTreeTilt;

/*
 * Beats 81.25% by speed and 70.83% by memory
 */
public class Solution
{
    int max = 0;

    public int FindTilt(TreeNode root)
    {
        CalcSum(root);
        return max;
    }

    private int CalcSum(TreeNode root)
    {
        if (root == null)
            return 0;

        int leftSum = CalcSum(root.left);
        int rightSum = CalcSum(root.right);
        max += Math.Abs(rightSum - leftSum);
        return leftSum + rightSum + root.val;
    }
}
