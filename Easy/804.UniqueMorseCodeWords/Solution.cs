namespace Easy._804.UniqueMorseCodeWords;

/*
 * Beats 99.40% by speed and 91.07% by memory
 */
public class Solution
{
    private HashSet<string> _hashTable;
    private Dictionary<char, string> _alphabet = new Dictionary<char, string>()
    {
        { 'a', ".-"},
        { 'b', "-..."},
        { 'c', "-.-."},
        { 'd', "-.."},
        { 'e', "."},
        { 'f', "..-."},
        { 'g', "--."},
        { 'h', "...."},
        { 'i', ".."},
        { 'j', ".---"},
        { 'k', "-.-"},
        { 'l', ".-.."},
        { 'm', "--"},
        { 'n', "-."},
        { 'o', "---"},
        { 'p', ".--."},
        { 'q', "--.-"},
        { 'r', ".-."},
        { 's', "..."},
        { 't', "-"},
        { 'u', "..-"},
        { 'v', "...-"},
        { 'w', ".--"},
        { 'x', "-..-"},
        { 'y', "-.--"},
        { 'z', "--.."}
    };

    public int UniqueMorseRepresentations(string[] words)
    {
        _hashTable = new HashSet<string>();

        for (int i = 0; i < words.Length; ++i)
        {
            string word = words[i];
            string code = "";
            for (int j = 0; j < word.Length; ++j)
            {
                code += _alphabet[word[j]];
            }
            _hashTable.Add(code);
        }

        return _hashTable.Count;
    }
}
