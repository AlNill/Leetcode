namespace Easy._168.ExcelSheetColumnTitle;

/*
 * As result code beats 50% by runtime and 50% by memory.
 */
public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        return columnNumber == 0 ? "" : ConvertToTitle(--columnNumber / 26) + (char)('A' + (columnNumber % 26));
    }
}

