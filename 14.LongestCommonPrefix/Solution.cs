using System.Text;

namespace _14.LongestCommonPrefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        StringBuilder result = new StringBuilder();
        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));
        string strWithMinLength = strs[0];
        int maxLen = strWithMinLength.Length;
        for(int i = 0; i < maxLen; ++i)
        {
            char currentSymbol = strWithMinLength[i];
            foreach(string str in strs)
            {
                if(currentSymbol != str[i])
                    return result.ToString();
            }
            result.Append(currentSymbol);
        }
        return result.ToString();
    }

    public string LongestCommonPrefixSolution(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        StringBuilder result = new StringBuilder();

        string firstStr = strs[0];
        for (int i = 0; i < firstStr.Length; ++i)
        {
            foreach (string str in strs)
            {
                if (i == str.Length || firstStr[i] != str[i])
                    return result.ToString();
            }
            result.Append(firstStr[i]);
        }
        return result.ToString();
    }
}
