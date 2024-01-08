namespace Easy._704.BinarySearch
{
    /*
     * Beats 30% by speed and 82% by memory
     */
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int medium = (right + left) / 2;
                if (nums[medium] > target)
                {
                    right = medium - 1;
                }
                else if (nums[medium] < target)
                {
                    left = medium + 1;
                }
                else
                    return medium;
            }
            return -1;
        }
    }
}
