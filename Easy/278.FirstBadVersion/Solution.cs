namespace Easy._278.FirstBadVersion;

public class VersionControl
{ }


/*
 * Beats 84.99% by speed and 37.30% by memory
 */
public class Solution : VersionControl
{
    /* The isBadVersion API is defined in the parent class VersionControl.
          bool IsBadVersion(int version); */
    public bool IsBadVersion(int n )
    {
        return false;
    }

    public int FirstBadVersion(int n)
    {
        int l = 1, r = n;
        while (l <= r)
        {
            int m = l + ((r - l) / 2);
            if (IsBadVersion(m - 1) && IsBadVersion(m))
                r = m - 1;
            else if (!IsBadVersion(m - 1) && !IsBadVersion(m))
                l = m + 1;
            else
                return m;
        }
        return 0;
    }
}
