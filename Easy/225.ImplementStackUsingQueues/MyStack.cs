namespace Easy._225.ImplementStackUsingQueues;

/*
 * Beats 75.45% by speed and 84.15% by memory
 */
public class MyStack
{
    private Queue<int> _q;
    private Queue<int> _tmp;

    public MyStack()
    {
        _q = new Queue<int>();
        _tmp = new Queue<int>();
    }

    public void Push(int x)
    {
        int count = _q.Count;
        for (int i = 0; i < count; ++i)
        {
            _tmp.Enqueue(_q.Dequeue());
        }

        _q.Enqueue(x);
        count = _tmp.Count;
        for (int i = 0; i < count; ++i)
        {
            _q.Enqueue(_tmp.Dequeue());
        }
    }

    public int Pop()
    {
        return _q.Dequeue();
    }

    public int Top()
    {
        return _q.Peek();
    }

    public bool Empty()
    {
        return _q.Count == 0;
    }
}