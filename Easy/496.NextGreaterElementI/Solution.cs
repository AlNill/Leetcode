namespace Easy._496.NextGreaterElementI;

/*
 * Beats 73.12% by speed and 42.82% by memory
 */
public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];
        Stack<int> st = new Stack<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int num2 in nums2)
        {
            while (st.Count > 0 && st.Peek() < num2)
            {
                dict.Add(st.Pop(), num2);
            }
            st.Push(num2);
        }

        for (int i = 0; i < nums1.Length; ++i)
        {
            result[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] : -1;
        }

        return result;
    }
}
