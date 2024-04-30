
public class Solution {
    public long WonderfulSubstrings(string word) {
        int n = word.Length;
        long result = 0;
        int bitmask = 0;
        int[] count = new int[1024]; // 2^10
        
        count[0] = 1; // Empty string is considered wonderful
        
        for (int i = 0; i < n; i++) {
            bitmask ^= (1 << (word[i] - 'a')); // Toggle the bit for the current character
            
            result += count[bitmask]; // Add the count of substrings with the same bitmask
            
            // Check all possible substrings with one bit difference (at most one character appearing odd number of times)
            for (int j = 0; j < 10; j++) {
                int diffBit = bitmask ^ (1 << j);
                result += count[diffBit];
            }
            
            count[bitmask]++; // Update the count of substrings with the same bitmask
        }
        
        return result;
    }
}
