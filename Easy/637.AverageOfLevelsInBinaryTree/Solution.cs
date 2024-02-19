using Easy.Common;

namespace Easy._637.AverageOfLevelsInBinaryTree;

/*
 * Beats 91.28% by speed and 98.55% by memory
 */
public class Solution
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<double> result = new List<double>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            long tmp = 0, n = queue.Count;
            for (int i = 0; i < n; ++i)
            {
                TreeNode t = queue.Dequeue();
                if (t.left != null)
                    queue.Enqueue(t.left);
                if (t.right != null)
                    queue.Enqueue(t.right);
                tmp += t.val;
            }
            result.Add((double)tmp / n);
        }
        return result;
    }
}