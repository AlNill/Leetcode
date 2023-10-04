namespace Easy._500.KeyboardRow;

/*
 * Beats 99.22% by speed and 93.36% by memory
 */
public class Solution
{
    private HashSet<char> first = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
    private HashSet<char> second = new HashSet<char>() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
    private HashSet<char> thrid = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

    public string[] FindWords(string[] words)
    {
        List<string> result = new List<string>();
        foreach (string word in words)
        {
            bool flag = true;
            bool isFirst = first.Contains(word[0]);
            bool isSecond = second.Contains(word[0]);
            bool isThrid = thrid.Contains(word[0]);
            for (int i = 1; i < word.Length; ++i)
            {
                if (isFirst && !first.Contains(word[i]))
                {
                    flag = false;
                    break;
                }

                if (isSecond && !second.Contains(word[i]))
                {
                    flag = false;
                    break;
                }

                if (isThrid && !thrid.Contains(word[i]))
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
                result.Add(word);
        }
        return result.ToArray();
    }
}
