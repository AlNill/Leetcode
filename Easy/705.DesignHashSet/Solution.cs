namespace Easy._705.DesignHashSet;

/*
 * Beats 99.60% by speed and 11.90% by memory
 */
public class MyHashSet
{
    private int[] _hashTable;

    public MyHashSet()
    {
        _hashTable = new int[1000001];
    }

    public void Add(int key)
    {
        _hashTable[key] = 1;
    }

    public void Remove(int key)
    {
        _hashTable[key] = 0;
    }

    public bool Contains(int key)
    {
        return _hashTable[key] == 1;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
