public class Solution {
    public int StrStr(string haystack, string needle) {
        if (string.IsNullOrEmpty(needle))
            return 0;
        
        int haystackLength = haystack.Length;
        int needleLength = needle.Length;
        
        int[] lps = ComputeLPSArray(needle);
        
        int i = 0; // index for haystack
        int j = 0; // index for needle
        
        while (i < haystackLength) {
            if (haystack[i] == needle[j]) {
                i++;
                j++;
                
                if (j == needleLength)
                    return i - j; // found the needle at index i - j
            }
            else {
                if (j != 0)
                    j = lps[j - 1];
                else
                    i++;
            }
        }
        
        return -1; // needle not found in haystack
    }
    
    private int[] ComputeLPSArray(string needle) {
        int needleLength = needle.Length;
        int[] lps = new int[needleLength];
        
        int len = 0; // length of the previous longest prefix suffix
        int i = 1;
        
        while (i < needleLength) {
            if (needle[i] == needle[len]) {
                len++;
                lps[i] = len;
                i++;
            }
            else {
                if (len != 0) {
                    len = lps[len - 1];
                }
                else {
                    lps[i] = 0;
                    i++;
                }
            }
        }
        
        return lps;
    }
}