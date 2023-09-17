namespace Easy._242.ValidAnagram;

/*
 * Beats 68.31% by speed and 96.39% by memory
 */
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        int[] arr = new int[26];
        for (int i = 0; i < s.Length; ++i)
        {
            ++arr[s[i] - 'a'];
        }

        for (int i = 0; i < t.Length; ++i)
        {
            --arr[t[i] - 'a'];
        }

        foreach (int val in arr)
        {
            if (val != 0)
                return false;
        }
        return true;
    }
}