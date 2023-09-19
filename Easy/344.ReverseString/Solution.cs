namespace Easy._344.ReverseString;

/*
 * Beats 66.76% by sped and 50.41% by memory
 */
public class Solution
{
    public void ReverseString(char[] s)
    {
        int middle = s.Length / 2;
        for (int i = 0; i < middle; ++i)
        {
            char tmp = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = s[i];
            s[i] = tmp;
        }
    }
}
