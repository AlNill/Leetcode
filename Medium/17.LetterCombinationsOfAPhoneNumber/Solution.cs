namespace Medium._17.LetterCombinationsOfAPhoneNumber;


/*
 * Beats 93.88% by speed and 76.06% by memory
 */
public class Solution
{
    private Dictionary<char, List<string>> _dict = new Dictionary<char, List<string>>()
    {
        { '2', new List<string>() { "a", "b", "c" } },
        { '3', new List<string>() { "d", "e", "f" } },
        { '4', new List<string>() { "g", "h", "i" } },
        { '5', new List<string>() { "j", "k", "l" } },
        { '6', new List<string>() { "m", "n", "o" } },
        { '7', new List<string>() { "p", "q", "r", "s" } },
        { '8', new List<string>() { "t", "u", "v" } },
        { '9', new List<string>() { "w", "x", "y", "z" } }
    };

    public IList<string> LetterCombinations(string digits)
    {
        IList<string> result = new List<string>();
        if (digits.Length == 0)
            return result;

        result = _dict[digits[0]];
        for (int i = 1; i < digits.Length; ++i)
        {
            List<string> tmp = new List<string>();
            foreach (var letter in _dict[digits[i]])
            {
                foreach (string resStr in result)
                {
                    tmp.Add(resStr + letter);
                }
            }
            result = tmp;
        }
        return result;
    }
}
