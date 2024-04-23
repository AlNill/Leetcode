namespace Easy._697.DegreeOfAnArray;

/*
 * Beats 74.77% by speed and 100% by memory
 */
public class Solution
{
    public class Node
    {
        public int Count { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }

        public Node(int count, int left, int right)
        {
            Count = count;
            Left = left;
            Right = right;
        }
    }

    public int FindShortestSubArray(int[] nums)
    {
        Node[] counts = new Node[50000];
        for (int i = 0; i < nums.Length; ++i)
        {
            if (counts[nums[i]] == null)
                counts[nums[i]] = new Node(0, i, -1);
            ++counts[nums[i]].Count;
            counts[nums[i]].Right = i;
        }

        int degreeCount = -1, minLen = -1;
        for (int i = 0; i < 50000; ++i)
        {
            if (counts[i] == null)
                continue;
            if (counts[i].Count > degreeCount)
            {
                degreeCount = counts[i].Count;
                minLen = counts[i].Right - counts[i].Left + 1;
            }
            else if (counts[i].Count == degreeCount)
            {
                int tmpLen = counts[i].Right - counts[i].Left + 1;
                minLen = minLen < tmpLen ? minLen : tmpLen;
            }
        }

        return minLen;
    }
}
