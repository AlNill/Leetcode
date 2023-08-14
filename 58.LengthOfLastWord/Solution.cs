namespace _58.LengthOfLastWord;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int i = s.Length - 1, len = 0;
        while (i >= 0 && s[i] == ' ')
        {
            --i;
        }

        while(i >= 0 && s[i] != ' ')
        {
            ++len;
            --i;
        }
        return len;
    }
}
