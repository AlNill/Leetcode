namespace Easy._706.DesignHashMap;

/*
 * Beats 62.24% by speed and 85.42% by memory
 */
public class MyHashMap
{
    private int[] _hashTable;

    public MyHashMap()
    {
        _hashTable = new int[1000001];
    }

    public void Put(int key, int value)
    {
        _hashTable[key] = value + 1;
    }

    public int Get(int key)
    {
        return _hashTable[key] - 1;
    }

    public void Remove(int key)
    {
        _hashTable[key] = 0;
    }
}