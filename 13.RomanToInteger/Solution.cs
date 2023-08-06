namespace _13.RomanToInteger;

public class Solution
{
    Dictionary<char, int> map = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public int RomanToInt(string s)
    {
        int result = 0;
        char currentSymbol, prevSymbol;

        for(int i = s.Length - 1; i >= 0; --i)
        {
            currentSymbol = s[i];
            result += map[currentSymbol];
            if(currentSymbol == 'I' && i != s.Length - 1)
            {
                prevSymbol = s[i + 1];
                if(prevSymbol == 'V' || prevSymbol == 'X')
                {
                    result -= 2;
                    continue;
                }
            }
            else if(currentSymbol == 'X' && i != s.Length - 1)
            {
                prevSymbol = s[i + 1];
                if(prevSymbol == 'L' || prevSymbol == 'C')
                {
                    result -= 20;
                    continue;
                }
            }
            else if (currentSymbol == 'C' && i != s.Length - 1)
            {
                prevSymbol = s[i + 1];
                if (prevSymbol == 'D' || prevSymbol == 'M')
                {
                    result -= 200;
                    continue;
                }
            }
        }

        return result;
    }
}
