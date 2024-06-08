using System.Collections.Generic;

public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        int prefix = 0;
        Dictionary<int, int> prefixToIndex = new Dictionary<int, int>();
        prefixToIndex.Add(0, -1);

        for (int i = 0; i < nums.Length; ++i) {
            prefix += nums[i];
            if (k != 0)
                prefix %= k;
            
            if (prefixToIndex.ContainsKey(prefix)) {
                if (i - prefixToIndex[prefix] > 1)
                    return true;
            } else {
                prefixToIndex[prefix] = i;
            }
        }

        return false;
    }
}