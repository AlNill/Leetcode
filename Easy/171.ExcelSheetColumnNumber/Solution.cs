namespace Easy._171.ExcelSheetColumnNumber;

/*
 * As result code beats 80.90% by runtime and 72.41% by memory.
 */
public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int result = (int)(columnTitle[columnTitle.Length - 1] - 'A') + 1;
        int currentMultiple = 1;

        for (int i = columnTitle.Length - 2; i >= 0; --i)
        {
            int current = (int)(columnTitle[i] - 'A') + 1;
            currentMultiple *= 26;
            result += current * currentMultiple;
        }
        return result;
    }
}