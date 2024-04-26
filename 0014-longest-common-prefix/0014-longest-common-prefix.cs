public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return "";
        }
        
        // Start with the first string as the initial common prefix
        string prefix = strs[0];
        
        for (int i = 1; i < strs.Length; i++) {
            // Keep reducing the prefix until it matches the current string or becomes empty
            while (strs[i].IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "") {
                    return "";
                }
            }
        }
        
        return prefix;
    }
}