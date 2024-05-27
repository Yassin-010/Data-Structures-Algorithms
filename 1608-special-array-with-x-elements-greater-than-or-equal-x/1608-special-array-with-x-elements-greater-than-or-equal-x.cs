using System;
using System.Linq;

public class Solution
{
    public int SpecialArray(int[] nums)
    {
        Array.Sort(nums);

        if (nums[0] >= nums.Length)
            return nums.Length;

        for (int i = 1; i < nums.Length; ++i)
        {
            int count = nums.Length - i;
            if (nums[i - 1] < count && nums[i] >= count)
                return count;
        }

        return -1;
    }
}