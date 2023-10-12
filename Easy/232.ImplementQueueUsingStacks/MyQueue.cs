namespace Easy._232.ImplementQueueUsingStacks;

/*
 * Beats 94.63% by speed and 94.01% by memory
 */
public class MyQueue
{
    private Stack<int> _stack;
    private Stack<int> _tmp;

    public MyQueue()
    {
        _stack = new Stack<int>();
        _tmp = new Stack<int>();
    }

    public void Push(int x)
    {
        int count = _stack.Count;
        for (int i = 0; i < count; ++i)
        {
            _tmp.Push(_stack.Pop());
        }

        _stack.Push(x);
        for (int i = 0; i < count; ++i)
        {
            _stack.Push(_tmp.Pop());
        }
    }

    public int Pop()
    {
        return _stack.Pop();
    }

    public int Peek()
    {
        return _stack.Peek();
    }

    public bool Empty()
    {
        return _stack.Count == 0;
    }
}
