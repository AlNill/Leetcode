namespace Medium._22.GenerateParentheses;

/*
 * Beats 91.43% by speed and 57.22% by memory
 */
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> result = new List<string>();
        Dfs(result, 0, 0, "", n);
        return result;
    }

    private void Dfs(IList<string> result, int left, int right, string str, int n)
    {
        if (str.Length == n * 2)
        {
            result.Add(str);
            return;
        }

        if (left < n)
            Dfs(result, left + 1, right, str + "(", n);

        if (right < left)
            Dfs(result, left, right + 1, str + ")", n);
    }
}
