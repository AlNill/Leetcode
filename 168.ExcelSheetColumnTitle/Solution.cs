namespace _168.ExcelSheetColumnTitle;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        return columnNumber == 0 ? "" : ConvertToTitle(--columnNumber / 26) + (char)('A' + (columnNumber % 26));
    }
}
