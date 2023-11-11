using Easy.Common;

namespace Easy._589.N_aryTreePreorderTraversal;

/*
 * Beats 74.51% by speed and 58.17% by memory
 */
public class Solution
{
    private IList<int> _result = new List<int>();
    public IList<int> Preorder(Node root)
    {
        FillPreorder(root);
        return _result;
    }

    private void FillPreorder(Node root)
    {
        if (root == null)
            return;
        _result.Add(root.val);
        foreach (var child in root.children)
        {
            FillPreorder(child);
        }
    }
}
