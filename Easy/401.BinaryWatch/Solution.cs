namespace Easy._401.BinaryWatch;

/*
 * Beats 100% by speed and 37.25% by memory
 */
public class Solution
{
    private int BitCount(int val)
    {
        int count = 0;
        for (int i = 0; i < 6; ++i)
        {
            if ((val & 1) == 1)
                ++count;
            val >>= 1;
        }
        return count;
    }

    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        IList<string> result = new List<string>();
        for (int i = 0; i < 12; ++i)
        {
            for (int j = 0; j < 60; ++j)
            {
                if (BitCount(j) + BitCount(i) != turnedOn)
                    continue;
                result.Add(String.Format("{0}:{1,2:00}", i, j));
            }
        }
        return result;
    }
}
