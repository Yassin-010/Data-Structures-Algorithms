public class Solution {

public int ThreeSumClosest(int[] nums, int target) {
    Array.Sort(nums); // Sort the array in ascending order
    int closestSum = nums[0] + nums[1] + nums[2]; // Initialize closestSum with the sum of the first three elements
    
    for (int i = 0; i < nums.Length - 2; i++) {
        int left = i + 1; // Pointer to the element next to nums[i]
        int right = nums.Length - 1; // Pointer to the last element
        
        while (left < right) {
            int sum = nums[i] + nums[left] + nums[right]; // Calculate the sum of the current triplet
            
            if (sum == target) {
                return sum; // Found an exact match, return the sum
            }
            
            // Update closestSum if the current sum is closer to the target
            if (Math.Abs(sum - target) < Math.Abs(closestSum - target)) {
                closestSum = sum;
            }
            
            if (sum < target) {
                left++; // Move the left pointer to increase the sum
            } else {
                right--; // Move the right pointer to decrease the sum
            }
        }
    }
    
    return closestSum;
}
}