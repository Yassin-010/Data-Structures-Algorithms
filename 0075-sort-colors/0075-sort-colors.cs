public class Solution {
    public void SortColors(int[] nums) {
        int zero = -1;
        int one = -1;
        int two = -1;

        foreach (int num in nums) {
            if (num == 0) {
                nums[++two] = 2;
                nums[++one] = 1;
                nums[++zero] = 0;
            } else if (num == 1) {
                nums[++two] = 2;
                nums[++one] = 1;
            } else {
                nums[++two] = 2;
            }
        }
    }
}