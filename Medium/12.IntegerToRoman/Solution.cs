namespace Medium._12.IntegerToRoman;

public class Solution
{
    private Dictionary<int, string> _keys = new Dictionary<int, string>() {
        { 1, "I" },
        { 2, "II" },
        { 3, "III" },
        { 4, "IV" },
        { 5, "V" },
        { 6, "VI" },
        { 7, "VII" },
        { 8, "VIII" },
        { 9, "IX" },
        { 10, "X" },
        { 20, "XX" },
        { 30, "XXX" },
        { 40, "XL" },
        { 50, "L" },
        { 60, "LX" },
        { 70, "LXX" },
        { 80, "LXXX" },
        { 90, "XC" },
        { 100, "C" },
        { 200, "CC" },
        { 300, "CCC" },
        { 400, "CD" },
        { 500, "D" },
        { 600, "DC" },
        { 700, "DCC" },
        { 800, "DCCC" },
        { 900, "CM" },
        { 1000, "M" },
        { 2000, "MM" },
        { 3000, "MMM" }
    };

    private string IntToRomanFromDictionary(int num)
    {
        if (_keys.ContainsKey(num))
            return _keys[num];
        return "";
    }

    /*
     * Beats 66.1% by speed and 5.64% by memory
     */
    public string IntToRomanDict(int num)
    {
        string result = "";
        int counter = 1;
        while (num != 0)
        {
            int tmp = (num % 10) * counter;
            counter *= 10;
            num /= 10;
            result = IntToRomanFromDictionary(tmp) + result;
        }
        return result;
    }

    /*
    * Beats 78.28% by speed and 59.83% by memory
    */
    public string IntToRoman(int num)
    {
        string[] units = new string[10] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tens = new string[10] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] hundreds = new string[10] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] thousands = new string[4] { "", "M", "MM", "MMM" };
        return thousands[num / 1000] + hundreds[(num % 1000) / 100] + tens[(num % 100) / 10] + units[num % 10];
    }
}