namespace _28.FindTheIndexOfTheFirstOccurrenceInAString;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if(needle.Length > haystack.Length)
            return -1;

        for(int i = 0; i < haystack.Length; ++i)
        {
            if (needle.Length > haystack.Length - i)
                return -1;
            bool success = true;
            for(int j = 0; j < needle.Length; ++j)
            {                
                if (needle[j] != haystack[i + j])
                {
                    success = false;
                    break;
                }
            }
            if (success)
                return i;
        }

        return -1;
    }
}
