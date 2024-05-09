using System;

public class Solution 
{
    public long MaximumHappinessSum(int[] happiness, int k) 
    {
        int n = happiness.Length;
        long ans = 0;
        int decremented = 0;

        Array.Sort(happiness);

        for (int i = n - 1; i >= n - k; --i) 
        {
            ans += Math.Max(0, happiness[i] - decremented);
            ++decremented;
        }

        return ans;
    }
}