public class Solution
{
    public int[] SingleNumber(int[] nums)
    {
        int xors = nums.Aggregate((a, b) => a ^ b);
        int lowbit = xors & -xors;
        int[] ans = new int[2];

        // Separate `nums` into two groups by `lowbit`.
        foreach (int num in nums)
        {
            if ((num & lowbit) > 0)
                ans[0] ^= num;
            else
                ans[1] ^= num;
        }

        return ans;
    }
}