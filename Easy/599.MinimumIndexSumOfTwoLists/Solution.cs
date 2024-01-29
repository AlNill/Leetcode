namespace Easy._599.MinimumIndexSumOfTwoLists;

/*
 * Beats 99.38% by speed and 21.12% by memory
 */
public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        HashSet<string> result = new HashSet<string>();
        Dictionary<string, int> map1 = new Dictionary<string, int>();
        Dictionary<string, int> map2 = new Dictionary<string, int>();

        int n = 0, distance = Int32.MaxValue;
        while (n < list1.Length && n < list2.Length)
        {
            map1.Add(list1[n], n);
            map2.Add(list2[n], n);

            if (map1.ContainsKey(list2[n]) && map1[list2[n]] + n <= distance)
            {
                if (map1[list2[n]] + n == distance)
                    result.Add(list2[n]);
                else
                {
                    result.Clear();
                    result.Add(list2[n]);
                    distance = map1[list2[n]] + n;
                }
            }

            if (map2.ContainsKey(list1[n]) && map2[list1[n]] + n <= distance)
            {
                if (map2[list1[n]] + n == distance)
                    result.Add(list1[n]);
                else
                {
                    result.Clear();
                    result.Add(list1[n]);
                    distance = map2[list1[n]] + n;
                }
            }
            ++n;
        }

        if (n < list1.Length)
        {
            while (n < list1.Length)
            {
                if (map2.ContainsKey(list1[n]) && map2[list1[n]] + n <= distance)
                {
                    if (map2[list1[n]] + n == distance)
                        result.Add(list1[n]);
                    else
                    {
                        result.Clear();
                        result.Add(list1[n]);
                        distance = map2[list1[n]] + n;
                    }
                }
                ++n;
            }
        }

        if (n < list2.Length)
        {
            while (n < list2.Length)
            {
                if (map1.ContainsKey(list2[n]) && map1[list2[n]] + n <= distance)
                {
                    if (map1[list2[n]] + n == distance)
                        result.Add(list2[n]);
                    else
                    {
                        result.Clear();
                        result.Add(list2[n]);
                        distance = map1[list2[n]] + n;
                    }
                }
                ++n;
            }
        }
        return result.ToArray();
    }
}