using System.Text;

namespace Easy._557.ReverseWordsInAStringIII;

/*
 * Beats 63.62% by speed and 52.48% by memory
 */
public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder sb = new StringBuilder();
        int i = 0;
        while (i < s.Length)
        {
            if (s[i] == ' ')
            {
                sb.Append(s[i++]);
                continue;
            }

            StringBuilder reverseWord = new StringBuilder();
            while (i < s.Length && s[i] != ' ')
            {
                reverseWord.Insert(0, s[i++]);
            }

            sb.Append(reverseWord.ToString());
        }
        return sb.ToString();
    }
}
