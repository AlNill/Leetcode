namespace _125.ValidPalindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s.Length == 1)
            return true;

        int i = 0, j = s.Length - 1;
        while (i <= j)
        {
            while (!char.IsLetterOrDigit(s[i]))
            {
                ++i;
                if (i == s.Length)
                    return true;
            }
            while (!char.IsLetterOrDigit(s[j]))
                --j;
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
                return false;
            ++i;
            --j;
        }
        return true;
    }
}
