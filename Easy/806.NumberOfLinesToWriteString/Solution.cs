namespace Easy._806.NumberOfLinesToWriteString;

/*
 * Beats 93.06% by speed and 86.11% by memory
 */
public class Solution
{
    public int[] NumberOfLines(int[] widths, string s)
    {
        int i = 0, totalSum = 0, stringCount = 1;
        while (i < s.Length)
        {
            int letterWeight = widths[s[i] - 'a'];
            stringCount = totalSum + letterWeight > 100 ? stringCount + 1 : stringCount;
            totalSum = totalSum + letterWeight > 100 ? letterWeight : totalSum + letterWeight;
            ++i;
        }
        return new int[] { stringCount, totalSum };
    }
}