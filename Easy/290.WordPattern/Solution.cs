namespace Easy._290.WordPattern;

/*
 * Beats 74.02% by speed and 34.31% by memory;
 */
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> hashTable = new Dictionary<char, string>();
        var words = s.Split(' ');
        if (pattern.Length != words.Length)
            return false;
        for (int i = 0; i < pattern.Length; ++i)
        {
            if (!hashTable.ContainsKey(pattern[i]))
            {
                if (hashTable.ContainsValue(words[i]))
                    return false;
                hashTable.Add(pattern[i], words[i]);
            }
            else if (hashTable[pattern[i]] == words[i])
                continue;
            else
                return false;
        }
        return true;
    }
}
