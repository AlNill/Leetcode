using System.Text;

namespace Easy._504.Base7;

/*
 * Beats 69.81% by speed and 96.23% by memory
 */
public class Solution
{
    public string ConvertToBase7(int num)
    {
        bool isMinus = num < 0;
        num = Math.Abs(num);
        StringBuilder sb = new StringBuilder();
        while (num > 6)
        {
            sb.Insert(0, num % 7);
            num /= 7;
        }
        if (num != 0 || sb.Length == 0)
            sb.Insert(0, num);
        if (isMinus)
            sb.Insert(0, '-');
        return sb.ToString();
    }
}
