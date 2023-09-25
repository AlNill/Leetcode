using System.Collections;
using System.Text;

namespace Easy._405.ConvertANumberToHexadecimal;

/*
 * Beats 91.30% by speed and 67.39% by memory
 */
public class Solution
{
    private static Dictionary<uint, char> alphabet = new Dictionary<uint, char>()
    {
        {0, '0'},
        {1, '1'},
        {2, '2'},
        {3, '3'},
        {4, '4'},
        {5, '5'},
        {6, '6'},
        {7, '7'},
        {8, '8'},
        {9, '9'},
        {10, 'a'},
        {11, 'b'},
        {12, 'c'},
        {13, 'd'},
        {14, 'e'},
        {15, 'f'}
    };

    public string ToHex(int num)
    {
        if (num == 0)
            return "0";

        uint tmp = (uint)num;
        StringBuilder sb = new StringBuilder();
        while (tmp > 15)
        {
            uint letterKey = tmp % 16;
            sb.Insert(0, alphabet[letterKey]);
            tmp = tmp >> 4;
        }
        if (tmp != 0)
            sb.Insert(0, alphabet[tmp]);
        return sb.ToString();
    }
}
