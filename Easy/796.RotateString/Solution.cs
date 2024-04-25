namespace Easy._796.RotateString;

/*
 * Beats 89.88% by speed and 36.31% by memory
 */
public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (goal == s)
            return true;
        var tmp = s.Substring(1) + s[0];
        while (tmp != s)
        {
            if (tmp == goal)
                return true;
            tmp = tmp.Substring(1) + tmp[0];
        }
        return false;
    }
}