namespace Easy._409.LongestPalindrome;

/*
 * Beats 92.95% by speed and 22.76% by memory
 */
public class Solution
{
    public int LongestPalindrome(string s)
    {
        int result = 0;
        HashSet<char> hashTable = new HashSet<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (hashTable.Contains(s[i]))
            {
                hashTable.Remove(s[i]);
                result += 2;
            }
            else
            {
                hashTable.Add(s[i]);
            }
        }
        return hashTable.Count == 0 ? result : result + 1;
    }
}
