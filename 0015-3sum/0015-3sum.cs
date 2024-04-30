public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        int n = nums.Length;
        
        // Sort the array
        Array.Sort(nums);
        
        for (int i = 0; i < n - 2; i++) {
            // Skip duplicate elements
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            
            int left = i + 1;
            int right = n - 1;
            
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                
                if (sum == 0) {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    // Skip duplicate elements
                    while (left < right && nums[left] == nums[left + 1])
                        left++;
                    while (left < right && nums[right] == nums[right - 1])
                        right--;
                    
                    left++;
                    right--;
                } else if (sum < 0) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        
        return result;
    }
}