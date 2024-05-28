using System;

public class Solution {
    public int EqualSubstring(string s, string t, int maxCost) {
        int j = 0;
        for (int i = 0; i < s.Length; ++i) {
            maxCost -= Math.Abs(s[i] - t[i]);
            if (maxCost < 0)
                maxCost += Math.Abs(s[j] - t[j++]);
        }

        return s.Length - j;
    }
}