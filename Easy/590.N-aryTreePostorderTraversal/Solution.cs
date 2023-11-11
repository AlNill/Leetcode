using Easy.Common;

namespace Easy._590.N_aryTreePostorderTraversal;

/*
 * Beats 100% by speed and 21.49% by memory
 */
public class Solution
{
    private IList<int> _result = new List<int>();

    public IList<int> Postorder(Node root)
    {
        FillPostorder(root);
        return _result;
    }

    private void FillPostorder(Node root)
    {
        if (root == null)
            return;

        foreach (var child in root.children)
        {
            FillPostorder(child);
        }
        _result.Add(root.val);
    }
}
