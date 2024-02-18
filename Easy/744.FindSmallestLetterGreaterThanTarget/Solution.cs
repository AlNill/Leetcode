namespace Easy._744.FindSmallestLetterGreaterThanTarget;

/*
 * Beats 89.29% by speed and 60.71% by memory
 */
public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int min = Int32.MaxValue;
        char result = ' ';
        for (int i = 0; i < letters.Length; ++i)
        {
            if (letters[i] != target && letters[i] - target < min && letters[i] - target > 0)
            {
                result = letters[i];
                min = letters[i] - target;
            }
        }
        return result == ' ' ? letters[0] : result;
    }
}
