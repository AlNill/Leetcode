namespace Easy._680.ValidPalindromeII;

/*
 * Beats 73.19% by speed and 47.94% by memory
 */
public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
                return IsValidPalindrome(s, left, right - 1) || IsValidPalindrome(s, left + 1, right);
            ++left;
            --right;
        }
        return true;
    }

    private bool IsValidPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            ++left;
            --right;
        }
        return true;
    }
}