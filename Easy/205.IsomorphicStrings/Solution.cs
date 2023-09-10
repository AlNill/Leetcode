namespace Easy._205.IsomorphicStrings;

/*
 * Beats 53.96% by speed and Beats 78.55% by memory
 */
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> sDict = new Dictionary<char, char>();
        Dictionary<char, char> tDict = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; ++i)
        {
            if ((sDict.ContainsKey(s[i]) && sDict[s[i]] != t[i]) ||
                (tDict.ContainsKey(t[i]) && tDict[t[i]] != s[i]))
                return false;

            sDict[s[i]] = t[i];
            tDict[t[i]] = s[i];
        }
        return true;
    }
}
