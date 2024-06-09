public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int n = nums.Length;
        int[] prefixSum = new int[n + 1];
        int[] frequency = new int[k];
        int count = 0;

        // Calculate prefix sums
        for (int i = 0; i < n; i++) {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        // Calculate remainders and store frequencies
        for (int i = 0; i <= n; i++) {
            int remainder = prefixSum[i] % k;
            if (remainder < 0) {
                remainder += k; // Ensure positive remainder
            }
            frequency[remainder]++;
        }

        // Calculate the number of subarrays
        for (int i = 0; i < k; i++) {
            count += frequency[i] * (frequency[i] - 1) / 2;
        }

        return count;
    }
}