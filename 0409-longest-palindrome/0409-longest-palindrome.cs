public class Solution {
    public int LongestPalindrome(string s) {
        int ans = 0;
        int[] count = new int[128];

        foreach (char c in s.ToCharArray())
            ++count[c];

        foreach (int freq in count)
            ans += freq % 2 == 0 ? freq : freq - 1;

        bool hasOddCount = count.Any(freq => freq % 2 == 1);
        return ans + (hasOddCount ? 1 : 0);
    }
}