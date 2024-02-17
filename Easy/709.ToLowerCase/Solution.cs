using System.Text;

namespace Easy._709.ToLowerCase;

/*
 * Beats 90.91% by speed and 52.96% by memory
 */
public class Solution
{
    public string ToLowerCase(string s)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
                result.Append((char)(s[i] + 32));
            else
                result.Append(s[i]);
        }
        return result.ToString();
    }
}
