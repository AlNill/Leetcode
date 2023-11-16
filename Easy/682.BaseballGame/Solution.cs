namespace Easy._682.BaseballGame;

/*
 * Beats 80.63% by speed and 79.38% by memory
 */
public class Solution
{
    public int CalPoints(string[] operations)
    {
        int result = 0;
        Stack<int> storage = new Stack<int>();
        for (int i = 0; i < operations.Length; ++i)
        {
            if (operations[i] == "C")
            {
                storage.Pop();
            }
            else if (operations[i] == "D")
            {
                storage.Push(storage.Peek() * 2);
            }
            else if (operations[i] == "+")
            {
                int last = storage.Pop();
                int prev = storage.Peek();
                storage.Push(last);
                storage.Push(last + prev);
            }
            else
            {
                storage.Push(Int32.Parse(operations[i]));
            }
        }

        while (storage.Count != 0)
        {
            result += storage.Pop();
        }
        return result;
    }
}