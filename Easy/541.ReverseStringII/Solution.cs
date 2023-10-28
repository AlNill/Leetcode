namespace Easy._541.ReverseStringII;

/*
 * Beats 40.78% by speed and 78.21% by memory
 */
public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] arr = s.ToCharArray(0, s.Length);
        int i = 0;
        while (i < s.Length)
        {
            int l = i;
            int r = Math.Min(i + k - 1, s.Length - 1);
            while (l < r)
            {
                var tmp = arr[r];
                arr[r--] = arr[l];
                arr[l++] = tmp;
            }
            i += 2 * k;
        }

        return new string(arr);
    }
}
