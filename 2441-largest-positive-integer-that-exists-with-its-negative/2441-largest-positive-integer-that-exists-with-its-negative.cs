
public class Solution {
    public int FindMaxK(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        int maxK = -1;
        
        foreach (int num in nums) {
            if (set.Contains(-num) && Math.Abs(num) > maxK) {
                maxK = Math.Abs(num);
            }
            set.Add(num);
        }
        
        return maxK == -1 ? -1 : maxK;
    }
}