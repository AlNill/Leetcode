using System.Collections;
using System.Text;

namespace Easy._405.ConvertANumberToHexadecimal;

/*
 * Beats 91.30% by speed and 67.39% by memory
 */
public class Solution
{
    private static string alphabet = "0123456789abcdef";

    public string ToHex(int num)
    {
        if (num == 0)
            return "0";
        uint tmp = (uint)num;
        StringBuilder sb = new StringBuilder();
        while (tmp > 15)
        {
            uint letterKey = tmp % 16;
            sb.Insert(0, alphabet[(int)letterKey]);
            tmp = tmp >> 4;
        }
        if (tmp != 0)
            sb.Insert(0, alphabet[(int)tmp]);
        return sb.ToString();
    }
}