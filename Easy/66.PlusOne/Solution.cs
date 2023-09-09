namespace Easy._66.PlusOne;

/*
 * As result code beats 97.13% by runtime and 18.29% by memory.
 */
public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        if (digits[digits.Length - 1] != 9)
        {
            ++digits[digits.Length - 1];
            return digits;
        }

        for (int i = digits.Length - 1; i >= 0; --i)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
                continue;
            }
            else
            {
                ++digits[i];
                return digits;
            }
        }

        var result = new int[digits.Length + 1];
        result[0] = 1;
        for (int i = 0; i < digits.Length; ++i)
            result[i + 1] = digits[i];
        return result;
    }
}
