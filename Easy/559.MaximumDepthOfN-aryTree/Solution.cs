using Easy.Common;
using System.Xml.Linq;

namespace Easy._559.MaximumDepthOfN_aryTree;

/*
 * Beats 99.28% by speed and 11.59% by memory
 */
public class Solution
{
    public int MaxDepth(Node root)
    {
        if (root == null)
            return 0;
        int height = 0;
        foreach (var child in root.children)
        {
            height = Math.Max(height, MaxDepth(child));
        }
        return 1 + height;
    }
}
