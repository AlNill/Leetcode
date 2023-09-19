namespace Easy._345.ReverseVowelsOfAString;

/*
 * Beats 83.15% by speed and 56.19% by memory
 */
public class Solution
{
    private bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) >= 0;
    }

    public string ReverseVowels(string s)
    {
        int l = 0, r = s.Length - 1;
        char[] sArr = s.ToArray();
        while (l <= r)
        {
            if (IsVowel(sArr[l]) && IsVowel(sArr[r]))
            {
                char tmp = sArr[l];
                sArr[l] = sArr[r];
                sArr[r] = tmp;
                ++l;
                --r;
            }
            else if (IsVowel(sArr[l]))
            {
                --r;
            }
            else if (IsVowel(sArr[r]))
            {
                ++l;
            }
            else
            {
                ++l;
                --r;
            }
        }
        return new string(sArr);
    }
}
