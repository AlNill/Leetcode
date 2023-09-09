namespace Easy._58.LengthOfLastWord;

/*
 * As result code beats 92.50% by runtime and 48.47% by memory.
 */
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int i = s.Length - 1, len = 0;
        while (i >= 0 && s[i] == ' ')
        {
            --i;
        }

        while (i >= 0 && s[i] != ' ')
        {
            ++len;
            --i;
        }
        return len;
    }
}
