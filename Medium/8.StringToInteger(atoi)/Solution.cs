namespace Medium._8.StringToInteger_atoi_;

/*
 * Beats 79.25% by speed and 96.68% by memory
 */
public class Solution
{
    public int MyAtoi(string s)
    {
        int result = 0, startPosition = 0, sign = 1;
        if (string.IsNullOrEmpty(s))
            return 0;
        while (startPosition < s.Length && s[startPosition] == ' ')
        {
            ++startPosition;
        }
        if (startPosition >= s.Length)
            return 0;
        else if (s[startPosition] == '-')
        {
            sign = -1;
            ++startPosition;
        }
        else if (s[startPosition] == '+')
        {
            sign = 1;
            ++startPosition;
        }

        int minThreshold = Int32.MinValue / 10;
        int maxThreshold = Int32.MaxValue / 10;
        while (startPosition < s.Length && char.IsDigit(s[startPosition]))
        {
            if ((result < minThreshold) || (result == minThreshold && s[startPosition] - '0' >= 8))
                return Int32.MinValue;
            if ((result > maxThreshold) || (result == maxThreshold && s[startPosition] - '0' >= 7))
                return Int32.MaxValue;
            result *= 10;
            result += sign * (s[startPosition] - '0');
            ++startPosition;
        }
        return result;
    }
}