namespace Easy._520.DetectCapital;

/*
 * Beats 72.4% by speed and 55.91% by memory
 */
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (word.All(char.IsUpper) || word.All(char.IsLower))
            return true;
        if (char.IsLower(word[0]))
            return false;
        for (int i = 1; i < word.Length; ++i)
        {
            if (char.IsUpper(word[i]))
                return false;
        }
        return true;
    }
}
